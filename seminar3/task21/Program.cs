// // Задача №21:
// // Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// // A (3,6); B (2,1) -> 5,09
// // A (7,-5); B (1,-1) -> 7,21

double Distance(int ax, int ay, int bx, int by)
{
    double distance = 0;

    distance = Math.Sqrt((Math.Pow(bx - ax, 2)) + (Math.Pow(by - ay, 2)));
    return Math.Round(distance, 2);
}


System.Console.Write("Enter coordinate X for A >> ");
int ax = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter coordinate Y for A >> ");
int ay = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter coordinate X for B >> ");
int bx = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter coordinate Y for B >> ");
int by = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Distance = {Distance(ax, ay, bx, by)}");
