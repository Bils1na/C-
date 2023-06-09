// Задача №5. Напишите программу, которая на вход принимает 
// одно число (N), а на выходе показывает все целые числа 
// в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> "-2, -1, 0, 1, 2"

Console.Write("Enter number >> ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// if(number < 0)
// {
//     number = -number;
// }
int count_number = number * -1;

Console.Write($"{number} -> ");
while(count_number != number + 1)
{
    if(count_number != number)
    {
        Console.Write($"{count_number}, ");
        count_number++;
    }
    else
    {
        Console.Write($"{count_number}");
        count_number++;
    }

}
