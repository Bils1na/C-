﻿// Задача 30: Напишите программу, которая 
// выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int [8]; 
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 2);
    // System.Console.Write($"{array[i]} ");
}


System.Console.Write(string.Join(", ", array));