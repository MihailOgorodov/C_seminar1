// **Задача 57:** Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] matrixArray = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(matrixArray);
WriteLine();

int[] dictionary = new int[parameters[3] - parameters[2]];

for (int k = 0; k < dictionary.Length; k++)
{
          dictionary[k] = 0;
          for (int i = 0; i < matrixArray.GetLength(0); i++)
          {
                    for (int j = 0; j < matrixArray.GetLength(1); j++)
                    {
                              if (matrixArray[i, j] == k + parameters[2]) dictionary[k]++;
                    }
          }
}

for (int k = 0; k < dictionary.Length; k++)
{
         WriteLine($"{k+parameters[2]} встречается {dictionary[k]} раз"); 
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
                              Write($"{inArray[i, j],3} ");
                    }
                    WriteLine();
          }
}

