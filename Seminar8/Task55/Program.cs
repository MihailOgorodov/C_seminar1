// **Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
using static System.Console;
Clear();

int[,] matrixArray = GetMatrixArray(4, 4, 1, 10);
PrintMatrixArray(matrixArray);
WriteLine();
ReverseMatrixArray(matrixArray);



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

void ReverseMatrixArray(int[,] inArray1)
{
          if(inArray1.GetLength(0) == inArray1.GetLength(1))
          for (int i = 0; i < inArray1.GetLength(0); i++)
          {
                    for (int j = 0; j < inArray1.GetLength(1); j++)
                    {
                              Write($"{inArray1[j, i],3} ");
                    }
                    WriteLine();
          }
          else Write("Заменить строки на столбцы невозможно");
}