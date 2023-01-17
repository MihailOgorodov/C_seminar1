// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.
using static System.Console;
Clear();

int[] Arr1 = GetArray(7);
PrintArray(Arr1);
WriteLine();

int[] Arr2 = MultyCount(Arr1);
PrintArray(Arr2);


int[] GetArray(int size)
{
          int[] resultArray = new int[size];
          for (int i = 0; i < resultArray.Length; i++)
          {
                    resultArray[i] = new Random().Next(0, 10);
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

int[] MultyCount(int[] inArray1)
{

          int sizeArray = inArray1.Length / 2;
          if (inArray1.Length % 2 == 1) sizeArray++;
          int[] result = new int[sizeArray];
          for (int i = 0; i < sizeArray; i++)
          {
                    result[i] = inArray1[i] * inArray1[inArray1.Length - 1 - i];
          }
          return result;
}
