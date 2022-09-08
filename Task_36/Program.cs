//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


// Программа


Console.WriteLine("Программа создаст массив заполненный случайными числами и покажет сумму элементов, стоящих на нечетных позициях.");
int razmer = 10;
int[] massiv = new int[razmer];
CreateArray(razmer);
Console.Write("Создан следующий массив: ");
PrintArray(massiv);
SummaNechetIndex(massiv, razmer);

//Блок Функций

void CreateArray(int razmer)
{
    for (int i = 0; i < razmer; i++)
    {
        massiv[i] = new Random().Next(-99, 1000);
    }
}

void PrintArray(int[] array)
{
    var str = string.Join(", ", array);
    Console.WriteLine($"[ {str} ]");
}

void SummaNechetIndex(int[] array, int razmer)
{
    int summa = 0;
    for (int i = 0; i < razmer; i++)
    {
        if (i % 2 != 0)
        {
            summa+=array[i];
        }
    }
    Console.WriteLine("Сумма элементов, стоящих на нечетных позициях: " + summa);
}
