// Задача 37: Найдите произведение 
// пар чисел в одномерном массиве. 
// Парой считаем первый и последний 
// элемент, второй и предпоследний и 
// т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10);
    }
    
    return arr;
}

int[] ProductElements(int[] arr)
{
    int[] prod_arr = new int[arr.Length / 2 + arr.Length % 2];
    
    for (int i = 0; i < arr.Length / 2; i++)
    {    
        prod_arr[i] = arr[i] * arr[(arr.Length - 1) - i];
    }
    if (arr.Length % 2 == 1)
    {
        prod_arr[prod_arr.Length - 1] = arr[arr.Length / 2];
    }

    return prod_arr;    
}

System.Console.Write("Enter number elements of array >> ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.Write($"[{string.Join(", ", array)}] -> ");

System.Console.Write($"[{string.Join(", ", ProductElements(array))}]");