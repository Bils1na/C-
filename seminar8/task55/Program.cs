// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет 
// строки на столбцы. В случае, если это 
// невозможно, программа должна вывести 
// сообщение для пользователя.

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

int[,] ChangeRowsAndColumns (int[,] matrix, int row, int col)
{
    int [,] new_matrix = new int[col, row];

    for (int i = 0; i < matrix.GetLength(0) ; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            new_matrix[j, i] = matrix[i, j];
        }
    }

    return new_matrix;
}


System.Console.Write("Enter number rows >> ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number columns >> ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrix(matrix);
PrintMatrix(matrix);

System.Console.WriteLine();
int[,] new_matrix = ChangeRowsAndColumns(matrix, row, column);
PrintMatrix(new_matrix);