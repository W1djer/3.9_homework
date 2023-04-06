// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Function(int a, int b)
{
    if (a == b) return a;
    return a + Function(a + 1, b);
}

Console.Write("Введите числа: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write($"Сумма чисел = {Function(numbers[0], numbers[1])}");