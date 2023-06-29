// Задача 32: Напишите программу замена 
// элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] ChangeSign(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
    return arr;
}


int[] array = {-4, 8, -8, 2};

System.Console.Write($"[{string.Join(", ", array)}] -> ");
System.Console.Write($"[{string.Join(", ", ChangeSign(array))}]");

