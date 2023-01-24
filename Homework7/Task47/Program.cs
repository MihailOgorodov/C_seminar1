// Задача 47. Напишите программу реализующую метод, который возвращает массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;
Clear();
Write("Введите размер матрицы и диапазон значений через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
double[,] array = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(array);

double[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
          Random rnd = new Random();
          double[,] resultMatrix = new double[rows, columns];
          for (int i = 0; i < rows; i++)
          {
                    for (int j = 0; j < columns; j++)
                    {
                              resultMatrix[i, j] = rnd.Next(minValue, maxValue + 1)/ 10.0;
                    }
          }
          return resultMatrix;
}

void PrintMatrixArray(double[,] inArray)
{
          for (int i = 0; i < inArray.GetLength(0); i++)
          {
                    for (int j = 0; j < inArray.GetLength(1); j++)
                    {
                              Write($"{inArray[i, j],7} ");
                    }
                    WriteLine();
          }
}

