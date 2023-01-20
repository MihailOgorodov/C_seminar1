// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
using static System.Console;
Clear();
Write("Введите 3 числа - 3 длины треугольника - через пробел: ");
string[] triangleLenght = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine(LengthOfTriangleSides(int.Parse(triangleLenght[0]), int.Parse(triangleLenght[1]), int.Parse(triangleLenght[2])) ? "Да, такой треугольник может быть" : "Нет, такого треугольника не может быть");

bool LengthOfTriangleSides(int a, int b, int c)
{
          return (a + b > c && a + c > b && b + c > a);
}
