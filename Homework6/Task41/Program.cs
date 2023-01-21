// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
using static System.Console;
Clear();

Write("Введите числа через пробел: ");
int[] firstArray = GetArray(ReadLine());

int numbers = NumberComparison(firstArray);
WriteLine($"Количество чисел больше нуля -> {numbers}");

int[] GetArray(string line)
{
          string[] lineArray = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
          int[] arr = new int[lineArray.Length];
          for (int i = 0; i < lineArray.Length; i++)
          {
                    arr[i] = Convert.ToInt32(lineArray[i]);
          }
          return arr;
}

int NumberComparison(int[] numArray)
{
          int result = 0;
          for (int i = 0; i < numArray.Length; i++)
          {
                    if (numArray[i] > 0)
                    {
                              result++;
                    }
          }
          return result;
}

