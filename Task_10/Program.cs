// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите 3-х значное число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Вторая цифра данного числа: {(number / 10) % 10}");