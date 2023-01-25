// Напишите программу реализующую методы, формирования двумерного массива и массива средних арифметических значений каждого столбца.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);

PrintMatrixArray(array);
WriteLine();

double[] changedArray = ColumnAveragesArray(array);

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
          Random rnd = new Random();
          int[,] resultArray = new int[rows, columns];
          for (int i = 0; i < rows; i++)
          {
                    for (int j = 0; j < columns; j++)
                    {
                              resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
                    }
          }
          return resultArray;
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

double[] ColumnAveragesArray(int[,] inArray1)
{
          double[] resultArray = new double[inArray1.GetLength(0)];
          for (int i = 0; i < inArray1.GetLength(0); i++)
          {
                    for (int j = 0; j < inArray1.GetLength(1); j++)
                    {
                              {
                                        resultArray[i] += inArray1[j, i];
                              }
                    }

          }
          foreach (double elem in resultArray)
          {
                    Write($"{elem / inArray1.GetLength(0), 5} ");
          }
          return resultArray;
}