// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными 
// числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

int EvenNumbers(int[] arr)
{
    int even = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            even += 1;
        }
    }
    return even;
}


System.Console.Write("Enter number elements of array >> ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);

System.Console.WriteLine($"[{string.Join(", ", array)}] -> {EvenNumbers(array)}");