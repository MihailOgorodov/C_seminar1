// Задача 38: Напишите программу реализующую методы формирования массива,
// заполненного случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.
// [3,3 7,1 22,5 2,2 78,2] -> 76
using static System.Console;
Clear();

double[] Arr = GetArray(5);
PrintArray(Arr);
WriteLine();

double Diff = MaxMinDiff(Arr);
WriteLine($"Разница между максимальным и минимальным элементами массива = {Diff}");

double[] GetArray(int size)
{
          double[] resultArray = new double[size];
          for (int i = 0; i < resultArray.Length; i++)
          {
                    resultArray[i] = new Random().Next(-10, 100) / 10.0;
          }
          return resultArray;
}

void PrintArray(double[] inArray)
{
          Write("[");
          for (int i = 0; i < inArray.Length - 1; i++)
          {
                    Write($"{inArray[i]}  ");
          }
          Write($"{inArray[inArray.Length - 1]}]");
}

double MaxMinDiff(double[] inArray2)
{
          double result = 0;
          double min = inArray2[0];
          double max = inArray2[0];
          for (int i = 0; i < inArray2.Length; i++)
          {
                    if (inArray2[i] < min)
                    {
                              min = inArray2[i];
                    }
                    if (inArray2[i] > max)
                    {
                              max = inArray2[i];
                    }
                    result = max - min;
          }

          return result;
}
