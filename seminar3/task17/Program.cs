// // Задача №17. Напишите программу, 
// которая принимает на вход координаты точки (X и Y),
// // причем X ≠ 0 и Y ≠ 0 и выдаёт номер 
// четверти плоскости, в которой находится эта точка.
// 1) X > 0; Y > 0   2) X < 0; Y > 0   3) X < 0; Y < 0   4) X > 0; Y < 0

void PrintQuarter(int x, int y)
{
    if(x > 0 && y > 0)
    {
        System.Console.WriteLine("Dot is on first quarter.");
    }
    else if(x < 0 && y > 0)
    {
        System.Console.WriteLine("Dot is on second quarter.");
    }
    else if(x < 0 && y < 0)
    {
        System.Console.WriteLine("Dot is on third quarter.");
    }
    else
    {
        System.Console.WriteLine("Dot is on fourth quarter.");
    }
}


System.Console.Write("Enter coordinate X >> ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter coordinate Y >> ");
int y = Convert.ToInt32(Console.ReadLine());

PrintQuarter(x, y);
