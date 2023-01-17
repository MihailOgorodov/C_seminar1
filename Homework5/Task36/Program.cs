// Задача 36: Напишите программу реализующую методы формирования массива,
//заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
using static System.Console;
Clear();
int[] Arr = GetArray(4);
int sum = SumOddElements(Arr);

PrintArray(Arr);
WriteLine();
WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {sum}");

int[] GetArray(int size)
{
          int[] resultArray = new int[size];
          for (int i = 0; i < resultArray.Length; i++)
          {
                    resultArray[i] = new Random().Next(-100, 100);
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

int SumOddElements(int[] inArray2)
{
          int result = 0;
          for (int i = 0; i < inArray2.Length; i++)
          {
                    if (i % 2 != 0)
                    {
                              result = result + inArray2[i];
                    }
          }
          return result;
}
