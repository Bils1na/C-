// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int DeleteMiddleNumber(int number)
{
    string digit1 = Convert.ToString(number / 100);
    string digit3 = Convert.ToString(number % 10);
    int result = Convert.ToInt32(digit1 + digit3);

    return result;
}

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);
System.Console.WriteLine($"{number} -> {DeleteMiddleNumber(number)}");
