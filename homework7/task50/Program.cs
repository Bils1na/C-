// Задача 50. Напишите программу, 
// которая на вход принимает позиции 
// элемента в двумерном массиве, и 
// возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> такого числа в массиве нет

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


System.Console.Write("Enter rows number >> ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter columns number >> ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrix(matrix);
PrintMatrix(matrix);

// 1 way

// string FindElementFirst(int[,] matrix, int row, int col)
// {
//     int res = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == row && j == col)
//             {
//                 res = matrix[i, j];
//             }
//         }
//     }

//     if (res != 0)
//     {
//         return $"{res}";
//     }
//     else 
//     {
//         return "Not found";
//     }
// }


// System.Console.Write("Enter row number >> ");
// int r = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter column number >> ");
// int c = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"[{r}, {c}] -> {FindElementFirst(matrix, r, c)}");

// 2 way

string FindElementSecond(int[,] matrix, int number)
{
    int row = 0;
    int col = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                row = i;
                col = j;

                return $"{number} -> [{row}, {col}]";
            }
        }
    }

    return "Not found";
}


System.Console.Write("Enter number >> ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{FindElementSecond(matrix, number)}");