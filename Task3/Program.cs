// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] CreatRndArr(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ReverseArray(int [] array, int i)
{
    if(i < array.Length)
    {
        Console.Write(array[array.Length - i - 1] + " ");
        ReverseArray(array, i + 1);
    }
}

Console.WriteLine("input array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min range");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max range");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreatRndArr(size, min, max);
PrintArray(array);
ReverseArray(array, 0);