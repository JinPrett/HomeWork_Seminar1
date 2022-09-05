// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// тут с учетом что всё в одной формуле, сделал без функции. Может и слегка перегруженная строчка получилась - 
// но зато мне кажется так экономнее, чем с функцией. Хотя с функцией было бы красивее наверное и более эргономично (из разряда красивше;) 

// Программа

Console.WriteLine("Введите координаты первой точки через Enter (x y z):");
var x1 = Convert.ToDouble(Console.ReadLine());
var y1 = Convert.ToDouble(Console.ReadLine());
var z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки через Enter (x y z):");
var x2 = Convert.ToDouble(Console.ReadLine());
var y2 = Convert.ToDouble(Console.ReadLine());
var z2 = Convert.ToDouble(Console.ReadLine());

double Dist = Math.Round((Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2))), 2); //формулу взяли в округление до 2 знака после запятой через Math.Round

Console.WriteLine("---------------------------");
Console.WriteLine($"Расстояние в 3D пространстве между точками ({x1},{y1},{z1}) и ({x2},{y2},{z2}) - равно {Dist}");
