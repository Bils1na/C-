// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая меняет 
// местами первую и последнюю строку массива.

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

void ChangeRows(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0)-1, j];
        matrix[matrix.GetLength(0)-1, j] = temp;
    }
}

System.Console.Write("Enter number rows >> ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number columns >> ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrix(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
ChangeRows(matrix);
PrintMatrix(matrix);

