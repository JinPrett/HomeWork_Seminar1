//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3в5)
//2, 4 -> 16

// Программа

Console.WriteLine("Введите число A: ");
var A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
var B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------------");
Console.WriteLine($"Число {A} в степени {B} равно {Stepen(A, B)}");

//Блок Функций

int Stepen(int numberA, int numberB)
{
    int result = Convert.ToInt32(MathF.Pow(numberA, numberB));
    return result;
}