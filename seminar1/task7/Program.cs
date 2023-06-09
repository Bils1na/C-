// Задача №7. Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает последнюю цифру 
// этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.Write("Enter number >> ");
int number = Convert.ToInt32(Console.ReadLine());
int last_digit = number % 10;

if(number > 99 && number < 1000)
{
    Console.Write($"{number} -> {last_digit}");
}
