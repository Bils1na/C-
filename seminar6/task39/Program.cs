// Задача 39: Напишите программу, которая
// перевернет одномерный массив.
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

int[] ReverseArray(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
    return arr;
}


System.Console.Write("Enter number elements of array >> ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);

System.Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", ReverseArray(array))}]");