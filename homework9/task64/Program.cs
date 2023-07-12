// Задача 64: Задайте значение N. Напишите 
// программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить 
// с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void RoadToNumber(int num, int count)
{
    if (count > num) return;
    RoadToNumber(num, count + 1); 
    System.Console.Write($"{count} ");
}


System.Console.Write("Enter number >> ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
RoadToNumber(number, count);