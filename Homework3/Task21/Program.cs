// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
using static System.Console;
Clear();

Write("Введите координаты точки a по оси x: ");
int.TryParse(ReadLine(), out int ax);

Write("Введите координаты точки a по оси y: ");
int.TryParse(ReadLine(), out int ay);

Write("Введите координаты точки a по оси z: ");
int.TryParse(ReadLine(), out int az);

Write("Введите координаты точки b по оси x: ");
int.TryParse(ReadLine(), out int bx);

Write("Введите координаты точки b по оси y: ");
int.TryParse(ReadLine(), out int by);

Write("Введите координаты точки b по оси z: ");
int.TryParse(ReadLine(), out int bz);

double hypotenuse = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2) + Math.Pow((az-bz), 2));


WriteLine($"Расстояние между точками а и b в 3D пространстве равно {hypotenuse:f2}");
