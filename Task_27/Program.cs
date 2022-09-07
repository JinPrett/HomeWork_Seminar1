// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Программа

Console.WriteLine("Программа считает сумму цифр в числе");
Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} = {Summa(number)}");

//Блок Функций

int Summa(int num)
{
    int sum = 0;
    for (int count = 0; count < num; num = num / 10)
    {
        sum += num % 10;
    }
    return sum;
}