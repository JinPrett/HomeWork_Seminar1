// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два целых числа:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if(x>y)
{
    Console.Write("Первое число - большое (max = " + x +"), второе - меньшее (min = " + y + ")!");
}
else if(x<y)
{
    Console.WriteLine("Второе число - большое (max = " + y +"), первое число - меньшее (min = " + x + ")!");
}
else if(x==y)
{
    Console.WriteLine("Оба числа равны");
}