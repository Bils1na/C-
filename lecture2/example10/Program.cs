int[] array = { 51, 82, 53, 64, 25, 46, 27, 18, 27 };

int n = array.Length;
int find = 27;

int index =  0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}