// Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
using static System.Console;
Clear();

int[] Arr = GetArray(4);
PrintArray(Arr);
WriteLine();
InverseArray(Arr);

int[] GetArray(int size)
{
          int[] resultArray = new int[size];
          for (int i = 0; i < resultArray.Length; i++)
          {
                    resultArray[i] = new Random().Next(-10, 10);
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

void InverseArray(int[] inArray1)
{
          Write("[");
          for (int i = 0; i < inArray1.Length - 1; i++)
          {
                    inArray1[i] *= -1;
                    Write($"{inArray1[i]},");
          }
          Write($"{inArray1[inArray1.Length - 1]}]");
}

