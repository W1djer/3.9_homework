// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Function (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Function(m - 1, 1);
    if (m > 0 && n > 0) return Function(m - 1, Function(m, n - 1));
return Function(m, n);
}

Console.Write("Введите числа M и N: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine($" A({numbers[0]},{numbers[1]}) = {Function(numbers[0], numbers[1])}");