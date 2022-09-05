// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//Блок Функций

void OpredeleniePalindrom(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}

// Программа

Console.Write("Введите пятизначное число: ");
var number = Convert.ToString(Console.ReadLine());
OpredeleniePalindrom(number);