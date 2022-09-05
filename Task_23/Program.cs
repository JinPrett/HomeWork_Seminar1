//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//Блок Функций

void Kub(int[] N)
{
    int i = 1;
    int Length = N.Length;
    while (i < Length)
    {
        N[i] = Convert.ToInt32(Math.Pow(i, 3));
        Console.Write(N[i] + " ");
        i++;
    }
}

// Программа

Console.Write("Введите число: ");
var N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N + 1];
Console.WriteLine($"Таблица кубов чисел от 1 до {N}:");
Kub(array);