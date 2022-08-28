// Задача 5: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.Write("Введите пожалуйста число:");
int N = Convert.ToInt32(Console.ReadLine());
int N_start = N*(-1);
while(N_start<=N)
{
    Console.Write(N_start + ", ");
    N_start++;
}