// Задача 19
// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Palindrom(string number)
{
    int number_end = number.Length - 1;
    string check = "";

    for (int i = 0; i <= number.Length - 1; i++)
    {
        if (number[i] == number[number_end - i])
        {
            check += number[i];
        }
    }

    if (check == number)
    {
        return $"{number} -> Yes";
    }
    else
    {
        return $"{number} -> No";
    }
}


System.Console.Write("Enter number >> ");
string number = Console.ReadLine();

System.Console.WriteLine(Palindrom(number));
