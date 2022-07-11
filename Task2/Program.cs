Console.WriteLine("Введите число...");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void Method(int n)
{
    while (n > 0)
{
    sum = sum + n % 10;
    n = n / 10;
}
Console.Clear();
Console.Write(num);
Console.Write(" -->");
Console.Write(sum);
} 
Method(num);