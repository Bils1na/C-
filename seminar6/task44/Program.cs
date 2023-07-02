// Задача 44: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fibonacci(int num)
{
    int fib_num_fir = 0;
    int fib_num_sec = 1;
    int fib_num_thi = fib_num_fir + fib_num_sec;

    for (int i = 1; i <= num; i++)
    {
        if(i == 1) System.Console.Write($"{fib_num_fir} ");
        else if(i == 2) System.Console.Write($"{fib_num_sec} ");
        else 
        {
            System.Console.Write($"{fib_num_thi} ");
            fib_num_fir = fib_num_sec;
            fib_num_sec = fib_num_thi;
            fib_num_thi = fib_num_fir + fib_num_sec;
        }
    }
}


System.Console.Write("Enter N >> ");
int number = Convert.ToInt32(Console.ReadLine());

Fibonacci(number);
