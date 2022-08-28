// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три целых числа:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int max = (int)MathF.Max(x,y);
max = (int)MathF.Max(max,z);
Console.WriteLine("Максимальное число из введённых = " + max);