// Задача 66: Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using static System.Console;
Clear();

Write("Введите числа M и N через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);

WriteLine($"Сумма натуральных элементов в промежутке от {parameters[0]} до {parameters[1]} -> {GetNumbers(parameters[0], parameters[1])}");


int GetNumbers(int minValue, int maxValue)
{
          if (minValue > maxValue)
          {
                    int temp = minValue;
                    minValue = maxValue;
                    maxValue = temp;
          }
          if (maxValue == minValue) return maxValue;
          else return GetNumbers(minValue, (maxValue - 1)) + maxValue;
}
