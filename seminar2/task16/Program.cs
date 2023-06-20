// Напишите программу, которая принимает 
// на вход два числа и проверяет, является 
// ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

string EqualQuarter(int numberA, int numberB)
{
    if(numberA == numberB * numberB || numberB == numberA * numberA)
    {
        return "Yes";
    }
    else
    {
        return "No";
    }
}

int numberA = 25;
int numberB = -5;
System.Console.WriteLine($"{numberA}, {numberB} -> {EqualQuarter(numberA, numberB)}");
