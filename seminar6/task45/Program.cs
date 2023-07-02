// Задача 45: Напишите программу, которая 
// будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }

    return arr;
}

int[] CopyArray(int[] arr)
{
    int[] new_arr = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        new_arr[i] = arr[i];
    }

    return new_arr;
}


System.Console.Write("Enter number elements of array >> ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);
System.Console.WriteLine($"Old array -> [{string.Join(", ", array)}]");
System.Console.WriteLine($"New array -> [{string.Join(", ", CopyArray(array))}]");

