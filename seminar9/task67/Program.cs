// Задача 67: Напишите программу,
// которая будет принимать на вход 
// число и возращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int DigitsSum(int number)
{
    int sum = 0;
    if(number == 0) return sum;
    return number % 10 + DigitsSum(number / 10);
}


System.Console.Write("Enter number >> ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = DigitsSum(number);
System.Console.WriteLine(sum);