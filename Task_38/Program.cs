//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


// Программа


Console.WriteLine("Программа создаст массив заполненный вещественными числами и найдет разницу между макс. и мин. элементами массива.");
int razmer = 10;
double[] numbers = new double[razmer];
CreateArray(razmer);
Console.Write("Создан следующий массив: ");
PrintArray(numbers);
Raznica(numbers, razmer);

//Блок Функций

void CreateArray(int razmer)
{
    for (int i = 0; i < razmer; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(1000)) /10;
    }
}

void PrintArray(double[] array)
{
    var str = string.Join(" , ", array);
    Console.WriteLine($"[ {str} ]");
}

void Raznica(double[] array, int razmer)
{
    double maxValue = numbers[0];
    double minValue = numbers[0];
    for(int i = 0;i<razmer; i++)
    {
        if(numbers[i]>maxValue)
        {
            maxValue=numbers[i];
        }
        if(numbers[i]<minValue)
        {
            minValue=numbers[i];
        }
    }
    double result=maxValue-minValue;
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {result}");
}