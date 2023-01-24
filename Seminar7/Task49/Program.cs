// **Задача 49:** Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4
using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
//string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//int[] intParams= Array.ConvertAll(parameters, int.Parse); // метод, который преобразует массив из одного типа данных в другой.

// или сделать рефакторинг
int[] intParams= Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse); // метод, который преобразует массив из одного типа данных в другой.

// int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);
PrintMatrixArray(array);
WriteLine();
int[,] changedArray = ChangeElementsMatrixArray(array);
PrintMatrixArray(changedArray);


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

int[,] ChangeElementsMatrixArray(int[,] inArray1)
{
          int[,] resultMatrix = new int[inArray1.GetLength(0), inArray1.GetLength(1)];
          for (int i = 0; i < inArray1.GetLength(0); i++)
          {
                    for (int j = 0; j < inArray1.GetLength(1); j++)
                    {
                              if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
                              {
                                        resultMatrix[i, j] = inArray1[i, j] * inArray1[i, j];
                              }
                              else resultMatrix[i, j] = inArray1[i, j];
                    }

          }
          return resultMatrix;
}