// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
using static System.Console;
Clear();

Write("Задан прямоугольный двумерный массив");
WriteLine();
int[,] matrixArray = GetMatrixArray(4, 6, 1, 10);
PrintMatrixArray(matrixArray);
WriteLine();


int sum = int.MaxValue;
int index = 0;
for (int i = 0; i < matrixArray.GetLength(0); i++)
{
          int temp = 0;
          for (int j = 0; j < matrixArray.GetLength(1); j++)
          {
                    temp += matrixArray[i, j];
          }
          if (temp < sum)
          {
                    sum = temp;
                    index = i;
          }
}
WriteLine("Строка: " + index + " Сумма - " + sum);


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
