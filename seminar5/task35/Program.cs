// Задача 35: Задайте одномерный массив 
// из 123 случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

int CheckRange(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 10 && arr[i] < 99)
        {
            count += 1;
        }
        
    }
    return count;
}


int[] array = FillArrayWithRandomNumber(123);
System.Console.Write($"[{string.Join(", ", array)}] -> ");
System.Console.Write($"{CheckRange(array)}");
