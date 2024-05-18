// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void NatNum(int m, int n)
{
    if(m <= n)
    {
        Console.WriteLine(m);
        m+= 1;
        NatNum(m, n);
    }
}

Console.WriteLine("Input minimal range");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal range");
int max = Convert.ToInt32(Console.ReadLine());
NatNum(min, max);
