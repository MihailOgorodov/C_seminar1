// Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] matrixArray = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(matrixArray);
WriteLine();

int minValue = matrixArray[0, 0];
int minIndexI = 0;
int minIndexJ = 0;

for (int i = 0; i < matrixArray.GetLength(0); i++)
{
          for (int j = 0; j < matrixArray.GetLength(1); j++)
          {
                    if (matrixArray[i, j] < minValue)
                    {
                              minValue = matrixArray[i, j];
                              minIndexI = i;
                              minIndexJ = j;
                    }
          }
}
WriteLine();

int[,] matrix2 = ShrinkMatrixByAdress(matrixArray, minValue);
WriteLine();
PrintMatrixArray(matrix2);

int[,] ShrinkMatrixByAdress(int[,] inMatrix, int inMinValue)
{
          if (inMatrix.GetLength(0) < 1 || inMatrix.GetLength(1) < 1) return inMatrix;
          int row = 0; int column = 0;
          for (int i = inMatrix.GetLength(0) - 1; i >= 0; i--)
          {
                    for (int j = inMatrix.GetLength(1) - 1; j >= 0; j--)
                    {
                              if (inMatrix[i, j] == inMinValue)
                              {
                                        row = i;
                                        column = j;
                              }
                    }
          }
          WriteLine($"Адрес минимального: {row}, {column}");
          int[,] resultMatrix = new int[inMatrix.GetLength(0) - 1, inMatrix.GetLength(1) - 1];
          for (int i = 0; i < inMatrix.GetLength(0); i++)
          {
                    for (int j = 0; j < inMatrix.GetLength(1); j++)
                    {
                              if (i < row && j < column) { resultMatrix[i, j] = inMatrix[i, j]; }
                              if (i < row && j > column) { resultMatrix[i, j - 1] = inMatrix[i, j]; }
                              if (i > row && j > column) { resultMatrix[i - 1, j - 1] = inMatrix[i, j]; }
                              if (i > row && j < column) { resultMatrix[i - 1, j] = inMatrix[i, j]; }
                    }
          }

          return resultMatrix;
}

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
