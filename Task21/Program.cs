// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
using static System.Console;
Clear();
int i = 1;

Write("Для вывода таблицы квадратов введите число: ");
bool isParse = int.TryParse(ReadLine(), out int n);
if (!isParse)
{
          WriteLine("Введено не число");
          return;
}
WriteLine($"Таблица квадратов от 1 до {n}");

while (i < n + 1)
{
          WriteLine($"Квадрат числа {i} = {Math.Pow(i, 2)}");
          i++;
}
