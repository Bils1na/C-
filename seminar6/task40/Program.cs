// Задача 40: Напишите программу, которая 
// принимает на вход три числа и проверяет, 
// может ли существовать треугольник со 
// сторонами такой длины.
// Теорема о неравенстве треугольника: каждая 
// сторона треугольника меньше суммы двух других сторон.

System.Console.WriteLine("Enter three numbers");
System.Console.Write("1 >> ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("2 >> ");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("3 >> ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA < numberB + numberC && 
    numberB < numberA + numberC && 
    numberC < numberA + numberB) System.Console.WriteLine("Yes");
else System.Console.WriteLine("No");