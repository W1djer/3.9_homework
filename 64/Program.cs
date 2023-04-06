string Function(int a, int b)
{
    if (a == b) return a.ToString();
    return Function(a + 1, b) + ", " + a.ToString();
}

Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
Console.Write(Function(1, x));