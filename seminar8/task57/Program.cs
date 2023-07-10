// Задача 57: Составить частотный словарь
// элементов двумерного массива. 
// Частотный словарь содержит информацию 
// о том, сколько раз встречается элемент 
// входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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

int FindMaxElement(int[,] matrix)
{
    int max = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max) 
            {
                max = matrix[i, j];
            }
        }
    }

    return max;
}

int FindMinElement(int[,] matrix)
{
    int min = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min) 
            {
                min = matrix[i, j];
            }
        }
    }

    return min;
}

void CreateFrequencyDict(int[,] matrix)
{
    int min = FindMinElement(matrix);
    int max = FindMaxElement(matrix);
    int count = 0;
    
    for (int n = min; n <= max; n++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == n) 
                {
                    count++;
                }
            }
        }
        if (count != 0)
        {
            System.Console.WriteLine($"{n} occurs {count} times in the array.");
            count = 0;
        }
    }
}

System.Console.Write("Enter number rows >> ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter number columns >> ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrix(matrix);
PrintMatrix(matrix);
CreateFrequencyDict(matrix);
