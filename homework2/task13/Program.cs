// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что 
// третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int number = new Random().Next(10, 1000);
System.Console.WriteLine(number);
if(number < 100)
{
    System.Console.WriteLine("Number is not long enough");
}
else
{
    while(number > 999)
    {
        number /= 10;
    }
    System.Console.WriteLine(number % 10);
}