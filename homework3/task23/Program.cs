// Задача 23
// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube(int number)
{
    int cube = 0;

    System.Console.Write($"{number} -> ");
    for (int i = 1; i <= number; i++)
    {
       cube = i * i * i;
       System.Console.Write($"{cube} "); 
    }
}


System.Console.Write("Enter number >> ");
int number = Convert.ToInt32(Console.ReadLine());

Cube(number);
