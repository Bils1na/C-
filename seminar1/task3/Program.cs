// Задача №3. Напишите программу, которая будет выдавать название 
// дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Enter number of day >> ");
int day = Convert.ToInt32(Console.ReadLine());

switch(day)
{
        case 1:
                Console.Write("Monday");
                break;
        case 2:
                Console.Write("Tuesday");
                break;
        case 3:
                Console.Write("Wednesday");
                break;
        case 4:
                Console.Write("Thursday");
                break;
        case 5:
                Console.Write("Friday");
                break;
        case 6:
                Console.Write("Saturday");
                break;
        case 7:
                Console.Write("Sunday");
                break;
        default:
                Console.Write("Error");
                break;
}