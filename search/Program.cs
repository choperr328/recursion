void naturalOrder(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m} ");
        naturalOrder(m + 1, n);
        
    }
    else
    {
        if(m > n)
        {
            Console.Write($"{m} ");
            naturalOrder(m-1,n);
        }
    }
}


naturalOrder(123,65);
