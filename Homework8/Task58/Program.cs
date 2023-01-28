// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using static System.Console;
Clear();

Write("Введите размер первой матрицы и диапазон значений через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
int[,] matrixArray = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(matrixArray);
WriteLine();

Write("Введите размер второй матрицы и диапазон значений через пробел: ");
int[] parametersSecond = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
int[,] matrixArray2 = GetMatrixArray(parametersSecond[0], parametersSecond[1], parametersSecond[2], parametersSecond[3]);
PrintMatrixArray(matrixArray2);
WriteLine();
int[,] resultMatrixArray = MultiMatrix(matrixArray, matrixArray2);
PrintMatrixArray(resultMatrixArray);

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

int[,] MultiMatrix(int[,] inArray1, int[,] inArray2)
{
          if (inArray1.GetLength(1) != inArray2.GetLength(0))
          {
                    throw new Exception("Умножение невозможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
          }
          else WriteLine("Произведение двух матриц выражено матрицей");
          int[,] resultMatrix = new int[inArray1.GetLength(0), inArray2.GetLength(1)];
          for (int i = 0; i < inArray1.GetLength(0); i++)
          {
                    for (int j = 0; j < inArray2.GetLength(1); j++)
                    {
                              for (int k = 0; k < inArray2.GetLength(0); k++)
                              {
                                        resultMatrix[i, j] += inArray1[i, k] * inArray2[k, j];
                              }
                    }
          }
          return resultMatrix;
}
