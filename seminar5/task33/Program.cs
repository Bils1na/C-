// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное 
// число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

string CheckNumber(int[] arr, int num)
{
    string result = "No";
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num)
        {
            result = "Yes";
        }
    }
    return result;
}


System.Console.Write("Enter number elements of array >> ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);
System.Console.WriteLine($"[{string.Join(", ", array)}]");

System.Console.WriteLine();

System.Console.Write("Enter number that you'd like to find >> ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Your number -> {number}");

System.Console.WriteLine();

System.Console.WriteLine($"{number} [{string.Join(", ", array)}] -> {CheckNumber(array, number)}");