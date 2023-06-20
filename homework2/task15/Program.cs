// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли 
// этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Enter day >> ");
int day = Convert.ToInt32(Console.ReadLine());

switch(day)
{
    case 1:
        System.Console.WriteLine("No"); 
        break;
    case 2:
        System.Console.WriteLine("No");
        break;
    case 3:
        System.Console.WriteLine("No");
        break;
    case 4:
        System.Console.WriteLine("No");
        break;
    case 5:
        System.Console.WriteLine("No");
        break;
    case 6:
        System.Console.WriteLine("Yes");
        break;
    case 7:
        System.Console.WriteLine("Yes");
        break;
    default:
        System.Console.WriteLine("Error");
        break;
}