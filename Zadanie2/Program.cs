Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1!");
Console.WriteLine("Modyfikacja 2!");
Console.WriteLine("Modyfikacja 3!");

static double getAverage (int[] array)
{
    double result = 0;
    
    foreach (int i in array)
    {
        result += i;
    }
    
    return result / array.Length;
} 