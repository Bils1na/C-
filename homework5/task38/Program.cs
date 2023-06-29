// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] FillArray(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 100, 2);
    }
    return arr;
}

double FindMaxNumber(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double FindMinNumber(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}


System.Console.Write("Enter number elements of array >> ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(size);

double max = FindMaxNumber(array);
double min = FindMinNumber(array);

System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"max = {max}, min = {min}");
System.Console.WriteLine($"{max} - {min} = {max - min}");