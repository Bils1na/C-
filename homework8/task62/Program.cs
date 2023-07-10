// Задача 62. Напишите программу, которая 
// заполнит спирально массив 4 на 4.
// Например, на выходе получается вот 
// такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void FillMatrix(string[,] matrix)
{
    int length = matrix.GetLength(0);
    int num = 0;
    int counter = 1;
    while(num < 2){
        for(int i = num;i < length - num - 1;i++)
        {
            if (counter < 10)
            {
                matrix[num, i] = $"0{counter++}"; 
            }
            else
            {
                matrix[num, i] = $"{counter++}";
            }
        }
        for(int i = num;i < length - num - 1;i++)
        {
            if (counter < 10)
            {
                matrix[i, length - 1 - num] = $"0{counter++}"; 
            }
            else
            {
                matrix[i, length - 1 - num] = $"{counter++}";
            }
        }
        for(int i = length - num - 1;i > num;i--)
        {
            if (counter < 10)
            {
                matrix[length - num - 1, i] = $"0{counter++}";
            }
            else
            {
                matrix[length - num - 1, i] = $"{counter++}";
            }
        }
        for(int i = length - num - 1;i > num;i--)
        {
            if (counter < 10)
            {
                matrix[i, num] = $"0{counter++}";
            } 
            else
            {
                matrix[i, num] = $"{counter++}";
            }
        }
        num++;
    }
    
}

void PrintMatrix(string[,] matrix)
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


System.Console.Write("Enter number rows >> ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number columns >> ");
int column = Convert.ToInt32(Console.ReadLine());
string[,] matrix = new string[row, column];
FillMatrix(matrix);
PrintMatrix(matrix);