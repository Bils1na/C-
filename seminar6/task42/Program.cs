// Задача 42: Напишите программу, 
// которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void GetBinaryView(int num)
{
    if(num == 0) return;

    GetBinaryView(num / 2);
    System.Console.Write(num % 2);
}


// char[] ConvertToBinary(int num_dec)
// {
//     string num_bin = "";

//     while (num_dec >= 2)
//     {
//         num_bin += Convert.ToString(num_dec % 2);
//         num_dec /= 2;
//     }

//     char[] chars = (num_bin += Convert.ToString(num_dec)).ToCharArray();
//     return chars;
// }

// void ReverseArray(char[] arr)
// {
//     char temp = arr[0];
//     for (int i = 0; i < arr.Length / 2; i++) 
//     {
//         temp = arr[i];
//         arr[i] = arr[arr.Length - 1 - i];
//         arr[arr.Length - 1 - i] = temp;
//     }
// }


System.Console.Write("Enter number >> ");
int number_dec = Convert.ToInt32(Console.ReadLine());
// char[] number_bin = ConvertToBinary(number_dec);
// ReverseArray(number_bin);

// System.Console.WriteLine($"{number_dec} = {string.Join("", number_bin)}");

GetBinaryView(number_dec);