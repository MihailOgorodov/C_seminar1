// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
using static System.Console;
Clear();

Write("Введите число: ");
int a = int.Parse(ReadLine()!);
int n = 1;

while (n <= a)
{
          Write($" {n}");
          n += 1;
}