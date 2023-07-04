// Задание 59: Задайте двумерный массив
// из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на 
// пересечении которых расположен наименьший 
// элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Наименьший элемент - 1, ны выходе получим
// следующий массив: 
// 9 4 2
// 2 2 6
// 3 4 7

void FillMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int FindMinRow(int[,] matrix)
{
    int min = matrix[0, 0];
    int min_row = 0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                min_row = i;
            }
        }
    }
    return min_row;
}

int FindMinColumn(int[,] matrix)
{
    int min = matrix[0, 0];
    int min_column = 0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                min_column = j;
            }
        }
    }
    return min_column;
}

void DeleteMin(int[,] matrix, int min_row, int min_column)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != min_row && j != min_column)
            {
                System.Console.Write($"{matrix[i, j]} ");
            }
        }
        if (i != min_row)
        {
            System.Console.WriteLine(); 
        }
    }
}

System.Console.Write("Enter rows number >> ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter columns number >> ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];

System.Console.WriteLine("Simple matrix >> ");
FillMatrix(matrix);
PrintMatrix(matrix);

System.Console.WriteLine("Without min row and column >> ");
DeleteMin(matrix, FindMinRow(matrix), FindMinColumn(matrix));