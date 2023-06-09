﻿// Задача 43: Напишите программу, 
// которая найдёт точку пересечения 
// двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void PointIntersectionLines(double k1, double b1, double k2, double b2)
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = k2 * x + b2;

    System.Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}


System.Console.Write("Enter b1 >> ");
double b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter k1 >> ");
double k1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter b2 >> ");
double b2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter k2 >> ");
double k2 = Convert.ToInt32(Console.ReadLine());

PointIntersectionLines(k1, b1, k2, b2);