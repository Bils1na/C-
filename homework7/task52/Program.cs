// Задача 52. Задайте двумерный массив 
// из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое 
// каждого столбца: 4,6; 5,6; 3,6; 3.

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

double FindAverage(int[,] matrix, int col)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == col)
            {
                sum += matrix[i, j];
            }
        }
    }

    return Math.Round((sum / matrix.GetLength(0)), 1);
}


System.Console.Write("Enter rows number >> ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter columns number >> ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrix(matrix);
PrintMatrix(matrix);

System.Console.Write("Average every columns = ");
for (int i = 0; i < column; i++)
{
    System.Console.Write($"{FindAverage(matrix, i)} ");
}