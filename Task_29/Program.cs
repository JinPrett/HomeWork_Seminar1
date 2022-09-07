// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// Программа

Console.WriteLine("Программа создает массив из 8 случайных элементов (диапазон от 0 до 100) и выводит его на печать.");
int razmer = 8;
int[] massiv = new int[razmer];
CreateArray(razmer);
Console.Write("Результат: ");
PrintArray(massiv, '[', ']', ", ", true);

//Блок Функций

void CreateArray(int razmer) // создает массив
{
    for (int i = 0; i < razmer; i++)
    {
        massiv[i] = new Random().Next(101);
    }
}

void PrintArray(int[] array, char start, char end, string razdel, bool endLine) // вывод массива на печать
{
    Console.Write(start);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(razdel);
    }
    Console.Write(end);
    if (endLine)
        Console.WriteLine();
}