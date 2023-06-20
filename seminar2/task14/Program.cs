// Напишите программу, которая принимает на 
// вход число и проверяет, кратно ли оно одновременно
// 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

string DoubleDiv(int number)
{
    if(number % 7 == 0 && number % 23 == 0)
    {
        return "Yes";
    }
    else
    {
        return "No";
    }
}

int number = new Random().Next(1, 1000);
System.Console.WriteLine($"{number} -> {DoubleDiv(number)}");
