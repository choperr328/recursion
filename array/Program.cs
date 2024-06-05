int[] array = { 1, 2, 5, 0, 10, 34 };
void matreshka(int size, int[] arr)
{

    if (size < 1)
    {
        Console.WriteLine($"{arr[size]}");
        return;
    }
    Console.Write($"{array[size]} ");
    matreshka(size - 1, array);



}
matreshka(array.Length-1, array);