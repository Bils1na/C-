// string num = "123ff";
// if (int.TryParse(num, out int number))
// {
//     System.Console.WriteLine(number);
// }
// else
// {
//     System.Console.WriteLine("not number");
// }


// Задача №21:
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Возведение в степень
double number = 9;
System.Console.WriteLine(Math.Pow(number, 2));

// Извлечение квадратного корня
System.Console.WriteLine(Math.Sqrt(number));

// Округление дробного числа
double num = 1.2324214;
System.Console.WriteLine(Math.Round(num, 2));

// Комбинация
System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(num, 3)), 2));
