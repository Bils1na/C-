// Задача 21
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(double ax, double ay, double az, double bx, double by, double bz)
{
    double distance = 0;

    distance = Math.Sqrt((Math.Pow(bx - ax, 2)) + 
                (Math.Pow(by - ay, 2)) + 
                (Math.Pow(bz - az, 2)));

    return Math.Round(distance, 2);
}


System.Console.Write("Enter coordinate X for A >> ");
double ax = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter coordinate Y for A >> ");
double ay = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter coordinate Z for A >> ");
double az = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter coordinate X for b >> ");
double bx = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter coordinate Y for B >> ");
double by = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter coordinate Z for B >> ");
double bz = Convert.ToInt32(Console.ReadLine());

System.Console.Write(Distance(ax, ay, az, bx, by, bz));
