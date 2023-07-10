// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixProduct(int[,] matrix_one, int[,] matrix_two)
{
    int[,] matrix_product = new int[matrix_one.GetLength(0), matrix_one.GetLength(1)];
    
    for (int i = 0; i < matrix_one.GetLength(0); i++)
    {
        for (int j = 0; j < matrix_one.GetLength(1); j++)
        {
            for (int k = 0; k < matrix_one.GetLength(1); k++)
            {
                matrix_product[i, j] += matrix_one[i, k] * matrix_two[k, j];
            }
        }
    }

    return matrix_product;
}


System.Console.Write("Enter number rows >> ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number columns >> ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix_one = new int[row, column];
int[,] matrix_two = new int[row, column];
FillMatrix(matrix_one);
FillMatrix(matrix_two);
PrintMatrix(matrix_one);
System.Console.WriteLine();
PrintMatrix(matrix_two);
System.Console.WriteLine();
int[,] matrix_product = MatrixProduct(matrix_one, matrix_two);
PrintMatrix(matrix_product);