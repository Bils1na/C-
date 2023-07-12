// Задача 69: Напишите программу, которая 
// на вход принимает два числа А и В, 
// и возводит число А в целую степень 
// В с помощью рекурсии.

// А = 3; В = 5 -> 243 (3^5)
// A = 2; B = 3 -> 8 (2^3)

int DegreeOfNumber(int number, int degree)
{
    if ( degree == 0 ) return 1;
    return number * DegreeOfNumber(number, degree - 1);
}


System.Console.Write("Enter number >> ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter degree of number >> ");
int numberB = Convert.ToInt32(Console.ReadLine());

int res = DegreeOfNumber(numberA, numberB);
System.Console.WriteLine(res);