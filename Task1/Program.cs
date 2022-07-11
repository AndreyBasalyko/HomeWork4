Console.WriteLine("Введите число...");
double f = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число...");
double s = Convert.ToDouble(Console.ReadLine());
if (s >= 0 )
{
    double d = Math.Truncate(s);
    if (s - d > 0.0)
    {
        Console.WriteLine("Введите натуральное число...");
    }
    else
    {
        double g = Math.Pow(f, s);
        Console.Clear();
        Console.Write(f);
        Console.Write(", ");
        Console.Write(s);
        Console.Write(" -->");
        Console.Write(g);
    }
}
else
{
    Console.WriteLine("Введите натуральное число...");
}