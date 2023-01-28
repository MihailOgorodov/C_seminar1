// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
using static System.Console;
Clear();

int[,,] matrixArray = GetMatrixArray(2, 2, 2, 1, 100);
PrintMatrixArray(matrixArray);
WriteLine();


int[,,] GetMatrixArray(int pows, int columns, int depth, int minValue, int maxValue)
{
          int[,,] resultMatrix = new int[pows, columns, depth];
          int[] temp = new int[resultMatrix.GetLength(0) * resultMatrix.GetLength(1) * resultMatrix.GetLength(2)];
          int number = 0;
          for (int i = 0; i < temp.GetLength(0); i++)
          {
                    temp[i] = new Random().Next(10, 100);
                    number = temp[i];
                    if (i >= 1)
                    {
                              for (int j = 0; j < i; j++)
                              {
                                        while (temp[i] == temp[j])
                                        {
                                                  temp[i] = new Random().Next(10, 100);
                                                  j = 0;
                                                  number = temp[i];
                                        }
                                        number = temp[i];
                              }
                    }
          }
          int count = 0;
          for (int x = 0; x < resultMatrix.GetLength(0); x++)
          {
                    for (int y = 0; y < resultMatrix.GetLength(1); y++)
                    {
                              for (int z = 0; z < resultMatrix.GetLength(2); z++)
                              {
                                        resultMatrix[x, y, z] = temp[count];
                                        count++;
                              }
                    }
          }
          return resultMatrix;
}

void PrintMatrixArray(int[,,] inArray)
{
          for (int i = 0; i < inArray.GetLength(0); i++)
          {
                    for (int j = 0; j < inArray.GetLength(1); j++)
                    {
                              for (int k = 0; k < inArray.GetLength(2); k++)
                              {
                                        Write($"{inArray[i, j, k]}({i}{j}{k}) ");
                              }
                    }
                    WriteLine();
          }
}

