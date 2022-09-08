//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// Программа


Console.WriteLine("Программа создаст массив заполненный случайными положительными 3-х значными числами и покажет количество чётных чисел в массиве.");
int razmer = 10;
int[] massiv = new int[razmer];
CreateArray(razmer);
Console.Write("Создан следующий массив: ");
PrintArray(massiv);
CheckChetnost(massiv, razmer);

//Блок Функций

void CreateArray(int razmer)
{
    for (int i = 0; i < razmer; i++)
    {
        massiv[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    var str = string.Join(", ", array);
    Console.WriteLine($"[ {str} ]");
}

void CheckChetnost(int[] array, int razmer)
{
    int result = 0;
    for (int i = 0; i < razmer; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    Console.WriteLine("Количество четных чисел в массиве: " + result);
}
