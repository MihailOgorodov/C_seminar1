// Задача 64: Напишите программу, которая реализует рекурсивный метод вывода всех натуральных числел в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using static System.Console;
Clear();

Write("Введите число N: ");
int N = Convert.ToInt32(ReadLine());

WriteLine(GetNumbers(N));

string GetNumbers(int number)
{
          if (number == 1) return number.ToString();
          else return $"{number}, {GetNumbers(number-1)}";   
}
