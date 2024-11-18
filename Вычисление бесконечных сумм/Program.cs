using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите количество членов n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double sum = CalculateSeriesSum(x, n);
        Console.WriteLine($"Сумма первых {n} членов ряда: {sum}");
    }

    static double CalculateSeriesSum(double x, int n)
    {
        double sum = 1.0;
        double term = 1.0; 

        for (int i = 1; i <= n; i++)
        {   
            term *= x / i; 
            sum += term; 
        }

        return sum;
    }
}