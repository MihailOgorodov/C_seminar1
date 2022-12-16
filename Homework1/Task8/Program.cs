// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
using static System.Console;
Clear();

Write("Введите число: ");
int a = int.Parse(ReadLine()!);
int n = 1;

while (n <= a )
{
          if (n % 2 == 0)
                    Write($" {n}");
                    n += 1;
}