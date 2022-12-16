// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
using static System.Console;
Clear();

WriteLine("Введите число a: ");
int a = int.Parse(ReadLine()!);

if (a % 2 == 0) WriteLine($"Число {a} четное");
else WriteLine($"Число {a} нечетное");
