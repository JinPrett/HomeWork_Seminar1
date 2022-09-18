 /*
 Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

//Блок Функций

double Read(string line)
{
    Console.WriteLine(line);
    return double.Parse(Console.ReadLine()??"");
}

void Uravnenie(double b1, double b2, double k1, double k2)
{
    if(b1==b2 && k1==k2) 
    {
        Console.WriteLine ("Прямые совпадают, точка пересечения отсутствует!");
    }
    else if (k1==k2)
    {
        Console.WriteLine("Прямые параллельны друг другу, точка пересечения отсутствует!");
    }
    else
    {
        var x = (-b2 + b1)/(-k1 + k2);
        var y = k2 * x + b2;

        x = Math.Round(x, 3);
        y = Math.Round(y, 3);

        Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    }
}

// Программа

double b1=Read("Введите значение b1: ");
double b2=Read("Введите значение b2: ");
double k1=Read("Введите значение k1: ");
double k2=Read("Введите значение k2: ");
Uravnenie(b1,b2,k1,k2);
