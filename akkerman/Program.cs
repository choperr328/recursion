int akkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return akkerman(n - 1, 1);
    }
    return akkerman(n - 1, akkerman(n, m - 1));

}

Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

int x = akkerman(n, m);
Console.WriteLine(x);


