// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Программа

Console.Clear();
Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine("Введите размер массива m x n и диапазон случайных значений для заполнения массива:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон (положительное число от 1 до 999): ");
int[,] array = new int[m, n];
CreateArray(array);
PrintArray(array);
int minSumLine = 0;
int sumLine = SummaRow(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SummaRow(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine($"строкa номер {minSumLine+1} является строкой с наименьшей суммой элементов (сумма элементов = {sumLine}) ");

//Блок Функций

int SummaRow(int[,] array, int i)
{
  int sumRow = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRow += array[i,j];
  }
  return sumRow;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}