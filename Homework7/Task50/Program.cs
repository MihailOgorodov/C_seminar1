// Задача 50. Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве,
// и возвращающий значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9
using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(array);

Write("Введите две позиции элемента (номер строки и номер столбца) через пробел: ");
int[] elementsPosition = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
if(elementsPosition[0] < array.GetLength(0) && elementsPosition[1] < array.GetLength(1))
{
          WriteLine($"Значение элемента в массиве = {array[elementsPosition[0], elementsPosition[1]]}");
}
else WriteLine("Такого элемента в массиве нет");

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
