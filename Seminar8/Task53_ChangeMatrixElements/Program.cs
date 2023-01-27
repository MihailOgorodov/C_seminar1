// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2
using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] matrixArray = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(matrixArray);
WriteLine();
int[,] array = ReverseMatrixArray(matrixArray);
PrintMatrixArray(array);

int[,] GetMatrixArray(int pows, int columns, int minValue, int maxValue)
{
          Random rnd = new Random();
          int[,] resultMatrix = new int[pows, columns];
          for (int i = 0; i < pows; i++)
          {
                    for (int j = 0; j < columns; j++)
                    {
                              resultMatrix[i, j] = rnd.Next(minValue, maxValue);
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
                              Write($"{inArray[i, j],3} ");
                    }
                    WriteLine();
          }
}

int[,] ReverseMatrixArray(int[,] inArray1)
{
          int[,] changedArray = new int[inArray1.GetLength(0), inArray1.GetLength(1)];
          for (int i = 0; i < inArray1.GetLength(0); i++)
          {
                    for (int j = 0; j < inArray1.GetLength(1); j++)
                    {
                              if (i == 0)
                              {
                                        changedArray[i, j] = inArray1[i, j];
                                        inArray1[i, j] = inArray1[inArray1.GetLength(0) - 1, j];
                                        inArray1[inArray1.GetLength(0) - 1, j] = changedArray[i, j];
                                        changedArray[i, j] = inArray1[i, j];
                              }
                              else changedArray[i, j] = inArray1[i, j];
                    }
          }
          return changedArray;
}

