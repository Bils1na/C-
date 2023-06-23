// Задача 26: Напишите программу, которая 
// принимает на вход число и выдаёт 
// количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int DigitCapacity(int num)
{
    int number_digit = 0;
    int temp = 0;
    if (num == 0)
    {
        number_digit = 1;
    }
    else
    {
        for (int i = 1; temp != num; i *= 10)
        {
            temp = temp + i * ((num / i) % 10);
            number_digit++;
        }
    }
    return number_digit;  
}


System.Console.Write("Enter number >> ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(DigitCapacity(number));
