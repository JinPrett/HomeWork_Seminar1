//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int number = new Random().Next(99999);
Console.WriteLine("Заданное число: " + number);
if (number < 100)
{
    Console.WriteLine("Третьей цифры у числа нет");
}
else
{
    while (number > 1000)
    {
        number = number / 10;
    }
    Console.WriteLine($"Третья цифра числа: {number % 10}");
}
