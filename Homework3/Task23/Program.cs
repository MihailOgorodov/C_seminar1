// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
using static System.Console;
Clear();

Write("Для вывода таблицы кубов введите число: ");
bool isParse = int.TryParse(ReadLine(), out int n);
if (!isParse)
{
          WriteLine("Введено не число");
          return;
}
WriteLine($"Таблица кубов от 1 до {n}");
int i = 1;
while (i <= n)
{
          WriteLine($"Куб числа {i} = {Math.Pow(i, 3)}");
          i++;
}
