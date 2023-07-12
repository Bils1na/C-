// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в 
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int DigitsSum(int a, int b)
{
    if (a > b) return 0;
    return a + DigitsSum(a + 1, b);
}


System.Console.Write("Enter first number >> ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter second number >> ");
int numberB = Convert.ToInt32(Console.ReadLine());

int sum = DigitsSum(numberA, numberB);
System.Console.WriteLine(sum);