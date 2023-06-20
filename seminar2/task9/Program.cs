// Напишите программу, которая выводит случайное число из 
// отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int DigitComparison(int number)
{
    int digit1 = number / 10;
    int digit2 = number % 10;
    int result = 0;

    if(digit1 > digit2)
    {
        result = digit1;
    }
    else
    {
        result = digit2;
    }

    return result;
}

int number = new Random().Next(10, 100);
System.Console.WriteLine($"Your random number -> {number}");
System.Console.WriteLine($"Max digit = {DigitComparison(number)}");
