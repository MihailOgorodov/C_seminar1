//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
using static System.Console;
Clear();

int number = new Random().Next(100, 1000);
WriteLine(number);
Write($"{number/100}{number%10}");

