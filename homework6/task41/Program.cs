// Задача 41: Пользователь вводит с 
// клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArray(int size)
{
    int[] arr = new int[size];
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    return arr;
}

int PositiveNumbers(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) 
        {
            count++;
        }
    }

    return count;
}

System.Console.Write("Enter number elements of array >> ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);

System.Console.WriteLine($"[{string.Join(", ", array)}] -> {PositiveNumbers(array)}");