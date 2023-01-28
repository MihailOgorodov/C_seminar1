// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] matrixArray = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(matrixArray);
WriteLine();
int[,] array = MatrixSort(matrixArray);
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
                              Write($"{inArray[i, j],5} ");
                    }
                    WriteLine();
          }
}

int[,] MatrixSort(int[,] inArray1)
{
          int[,] sortedArray = new int[inArray1.GetLength(0), inArray1.GetLength(1)];
          for (int i = 0; i < inArray1.GetLength(0); i++)
          {
                    for (int j = 0; j < inArray1.GetLength(1); j++)
                    {
                              for (int l = j + 1; l < inArray1.GetLength(1); l++)
                              {
                                        if (inArray1[i, j] < inArray1[i, l])
                                        {
                                                  int temp = inArray1[i, j];
                                                  inArray1[i, j] = inArray1[i, l];
                                                  inArray1[i, l] = temp;
                                                  sortedArray[i, j] = inArray1[i, j];
                                        }
                                        else sortedArray[i, j] = inArray1[i, j];
                              }

                    }
          }
          return sortedArray;
}