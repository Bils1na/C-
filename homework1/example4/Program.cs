// Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB && numberA > numberC)
{
    Console.Write($"max = {numberA}");
}
else if(numberB > numberA && numberB > numberC)
{
    Console.Write($"max = {numberB}");
}
else
{
    Console.Write($"max = {numberC}");
}