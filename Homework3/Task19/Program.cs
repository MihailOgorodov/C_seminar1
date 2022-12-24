// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
using static System.Console;
Clear();

WriteLine("Введите пятизначное число: ");
bool isParse = int.TryParse(ReadLine(), out int a);
if (!isParse)
{
          WriteLine("Введено не число");
          return;
}
if (a < 10000 || a > 99999)
{
          WriteLine("Введено не верное число");
}
else if (a % 10 == a / 10000 && a % 100 / 10 == a % 10000 / 1000)
{
          WriteLine("Введенное число - палиндром");
}
else
{
          WriteLine("Введенное число не является палиндромом");
}
