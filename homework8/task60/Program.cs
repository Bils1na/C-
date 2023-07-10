// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillMatrix(int[,,] matrix)
{
    int[] array = new int[matrix.GetLength(0) 
    * matrix.GetLength(1) * matrix.GetLength(2)];
    Random rnd = new Random();
    int count = 10;


    for (int i = 0; i < array.Length; i++)
    {
        array[i] = count;
        count++;
    }

    for (int i = 0; i < matrix.GetLength(2); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                int index = rnd.Next(array.Length);
                while (true)
                {
                    if (array[index] != 0)
                    {
                        matrix[j, k, i] = array[index];
                        array[index] = 0;
                        break;
                    }
                    index = rnd.Next(array.Length);
                }
            }            
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(2); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                System.Console.Write($"{matrix[j, k, i]} ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

void PrintMatrixIndex(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(2); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            System.Console.Write("|");
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                System.Console.Write($"{matrix[j, k, i]}({j}, {k}, {i})|");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}


System.Console.Write("Enter number rows >> ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number columns >> ");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter volume >> ");
int volume = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[row, column, volume];
FillMatrix(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintMatrixIndex(matrix);