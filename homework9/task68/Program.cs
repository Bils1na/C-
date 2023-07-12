// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    
    if (m != 0 && n == 0) 
    {
        return AkkermanFunction(m - 1, 1);
    }
    if ( m > 0 && n > 0)
    { 
        return AkkermanFunction(m - 1, 
        AkkermanFunction(m, n - 1));
    }
    return AkkermanFunction(m, n);
}


System.Console.Write("Enter first number >> ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter second number >> ");
int numberB = Convert.ToInt32(Console.ReadLine());

int res = AkkermanFunction(numberA, numberB);
System.Console.WriteLine(res);