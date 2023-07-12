// Задача 63: Задайте значение N.
// Напишите программу, которая
// выведет все натуральные числа 
// в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void RoadToNumber(int num)
{
    if(num == 0)
    {
        return;
    }
    RoadToNumber(num - 1);
    System.Console.Write($"{num} ");
}


System.Console.Write("Enter number >> ");
int number = Convert.ToInt32(Console.ReadLine());
RoadToNumber(number);