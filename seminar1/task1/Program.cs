﻿// Задача №1. Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.Write("Enter first number >> ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number >> ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
{
        Console.Write($"Number {numberA} == quater number {numberB}");
}
else
{
        Console.Write($"Number {numberA} != quater number {numberB}");
}