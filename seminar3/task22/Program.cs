// Задача №22:
// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void Square(int number)
{
    int square = 0;
    System.Console.Write($"{number} -> ");
    for (int i = 1; i <= number ; i++)
    {
        square = i * i;
        System.Console.Write($"{square} ");
    }
}


System.Console.Write("Enter number >> ");
int number = Convert.ToInt32(Console.ReadLine());

Square(number);
