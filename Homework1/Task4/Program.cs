// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
using static System.Console;
Clear();

WriteLine("Введите число a: ");
int a = int.Parse(ReadLine()!);

WriteLine("Введите число b: ");
int b = int.Parse(ReadLine()!);

WriteLine("Введите число c: ");
int c = int.Parse(ReadLine()!);

if (a > b && a > c)
{
          WriteLine($"Максимальное число {a}");
}
else if (b > a && b > c)
{
          WriteLine($"Максимальное число {b}");
}
else
{
          WriteLine($"Максимальное число {c}");
}