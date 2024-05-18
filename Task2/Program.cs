// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akker(m - 1, 1);

    }
    else if (m > 0 && n > 0)
    {
        return Akker(m - 1, Akker(m, n - 1));
    }
    return n + 1;
}
int res = Akker(3, 2);
Console.WriteLine(res);
