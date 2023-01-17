// Задача 35: Задайте одномерный массив из N случайных чисел. Задайте диапазон элементов.
// Найдите количество элементов массива, значения которых лежат в указанном диапазоне.
using static System.Console;
Clear();

int[] Arr1 = GetArray(10);
PrintArray(Arr1);
WriteLine();
WriteLine(FindCountNumbers(Arr1));



int[] GetArray(int size)
{
          int[] resultArray = new int[size];
          for (int i = 0; i < resultArray.Length; i++)
          {
                    resultArray[i] = new Random().Next(-50, 100);
          }
          return resultArray;
}

void PrintArray(int[] inArray)
{
          Write("[");
          for (int i = 0; i < inArray.Length - 1; i++)
          {
                    Write($"{inArray[i]},");
          }
          Write($"{inArray[inArray.Length - 1]}]");
}

int FindCountNumbers(int[] inArray1)
{
          int result = 0;
          foreach (var i in inArray1)
          {
                    if(i>=10 && i<=99) result++;
                    
          }
          return result;
}