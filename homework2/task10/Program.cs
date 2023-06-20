// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int MiddleDigit(int number)
{
    int two_digits = number % 100;
    int middle_digit = two_digits / 10;

    return middle_digit;
}

int number = new Random().Next(100, 1000);
System.Console.WriteLine($"{number} -> {MiddleDigit(number)}");
