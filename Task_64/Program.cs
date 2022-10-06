// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// Программа

Console.Clear();
Console.WriteLine($"Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
int m = InputInt("Введите положительное число M: ");
int n = InputInt("Введите положительное число N: ");
int temp = 0;
if (m > n)
{
    temp = m;
    m = n;
    n = temp;
}
Console.WriteLine(NaturalNumber(n, m));

// Блок Функций

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
