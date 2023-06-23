// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Degree(int number, int power)
{
    double result = Math.Pow(number, power);

    return result;
}

System.Console.Write("Enter number >> ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter power >> ");
int power = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Degree(number, power));
