// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
using static System.Console;
Clear();
int number = new Random().Next(10, 100);
WriteLine(number);
//int a1 = number / 10;
//int a2 = number % 10;
//int max = a1 > a2 ? a1 : a2;
// Тернарный оператор. После = условие. После ? истина, после : иначе. Если а1 больше а2, то макс а1. Иначе а2.
//Так как этот оператор возвращает данные, записываем сразу в WriteLine
// WriteLine(a1 > a2 ? a1 : a2);
// if (a1 > a2)
// {
//           WriteLine(a1);
// }
// else
// {
//           WriteLine(a2);
// }

// Либо весь код можно записать и без ввода новых переменных
WriteLine(number/10 > number%10 ? number/10 : number%10);