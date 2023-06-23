// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и выводит 
// их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

int[] DefineLengthArray()
{
    int array_length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int [array_length];
    
    return array;
}

System.Console.Write("Enter length for array >> ");
int[] array = DefineLengthArray();
System.Console.Write(string.Join(", ", FillArray(array)));
