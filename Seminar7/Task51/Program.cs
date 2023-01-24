// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
//(с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(array);
WriteLine();
int sumElements = SumMatrixElements(array);
WriteLine($"Сумма элементов главной диагонали: {sumElements}");

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
          Random rnd = new Random();
          int[,] resultMatrix = new int[rows, columns];
          for (int i = 0; i < rows; i++)
          {
                    for (int j = 0; j < columns; j++)
                    {
                              resultMatrix[i, j] = rnd.Next(minValue, maxValue + 1);
                    }
          }
          return resultMatrix;
}

void PrintMatrixArray(int[,] inArray)
{
          for (int i = 0; i < inArray.GetLength(0); i++)
          {
                    for (int j = 0; j < inArray.GetLength(1); j++)
                    {
                              Write($"{inArray[i, j],5} ");
                    }
                    WriteLine();
          }
}

// int SumMatrixElements(int[,] inArray1)
// {
//           int resultSum = 0;
//           for (int i = 0; i < inArray1.GetLength(0); i++)
//           {
//                     for (int j = 0; j < inArray1.GetLength(1); j++)
//                     {
//                               if (i == j) resultSum += inArray1[i, j];
//                     }
//           }
//           return resultSum;
// }

// рефакторинг
int SumMatrixElements(int[,] inArray1)
{
          int resultSum = 0;
          for (int i = 0; i < (inArray1.GetLength(0)<inArray1.GetLength(1)?inArray1.GetLength(0):inArray1.GetLength(1)); i++)
          {
                    resultSum += inArray1[i, i];
          }
          return resultSum;
}

