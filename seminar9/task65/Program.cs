// Задача 65: Задайте значения M и N.
// Напишите программу, которая выведетвсе 
// натуральные числа в промежутке от M до N.

// M = 1; N = 5; -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void FromAToB(int a, int b)
{
    if(b < a)
    {
        return;
    }
    FromAToB(a, b - 1);
    System.Console.Write($"{b} ");
}


System.Console.Write("Enter first number >> ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter second number >> ");
int numberB = Convert.ToInt32(Console.ReadLine());

FromAToB(numberA, numberB);