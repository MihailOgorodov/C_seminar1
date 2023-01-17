// Задача 34: Напишите программу реализующую методы формирования массива,
// заполненного случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
using static System.Console;
Clear();

int[] Arr = GetArray(10);
PrintArray(Arr);
WriteLine();
int sumCount = SumNumbers(Arr);
WriteLine($"Количество четных чисел в массиве = {sumCount}");

int[] GetArray(int size)
{
          int[] resultArray = new int[size];
          for (int i = 0; i < resultArray.Length; i++)
          {
                    resultArray[i] = new Random().Next(100, 1000);
          }
          return resultArray;
}

void PrintArray(int[] inArray)
{
          Write("[");
          for (int i = 0; i < inArray.Length - 1; i++)
          {
                    Write($"{inArray[i]},");
          }
          Write($"{inArray[inArray.Length - 1]}]");
}

int SumNumbers(int[] array)
{
          int result = 0;
          foreach (int i in array)
          {
                    if (i % 2 == 0)
                    result += 1;
          }
          return result;
}