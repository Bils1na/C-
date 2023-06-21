// Задача №18: Напишите программу, которая по 
// заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).
// 1) X > 0; Y > 0   2) X < 0; Y > 0   3) X < 0; Y < 0   4) X > 0; Y < 0

void QuarterNumber(int quarter)
{
    string[] quarters = { "X > 0; Y > 0", "X < 0; Y > 0", 
                        "X < 0; Y < 0", "X > 0; Y < 0"};

    if (quarter >= 1 && quarter <= 4)
    {
        System.Console.WriteLine(quarters[quarter - 1]);
    }
    else
    {
        System.Console.WriteLine("Error");
    }
}


System.Console.Write("Enter number of quarter >> ");
int quarter = Convert.ToInt32(Console.ReadLine());

QuarterNumber(quarter);
