using static System.Console;
Clear();

// Большой метод вывода массива в консоль
// void PrintArray(double[] inArray)
// {
//           Write("[");
//           for (int i = 0; i < inArray.Length - 1; i++)
//           {
//                     Write($"{inArray[i]}  ");
//           }
//           Write($"{inArray[inArray.Length - 1]}]");
// }
// Задача 39:** Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Write("Введите размер массива: ");
int arraySize = int.Parse(ReadLine()!);
int[] array = GetArray(arraySize);

//string stringArray = String.Join(",", array); // метод String.Join объединяет массив в 1 строку по указанному разделителю ",". Обратный метод String.Split
//WriteLine($"[{stringArray}]");
// Так как этот метод можно сразу написать в вывод, то делаем рекомпозицию

WriteLine($"[{String.Join(",", array)}]");
ReverseArray2(array);
WriteLine($"[{String.Join(",", array)}]");

//WriteLine($"[{String.Join(",", ReverseArray1(array))}]");

int[] GetArray(int size)
{
          int[] resultArray = new int[size];
          for (int i = 0; i < size; i++)
          {
                    resultArray[i] = new Random().Next(1, 10);
          }
          return resultArray;

}

// Метод, который на базе существующего вернет новый перевернутый массив. Его используют, когда исходный массив еще нужен.
int[] ReverseArray1(int[] inArray)
{
          int[] result = new int[inArray.Length];
          for (int i = 0; i < inArray.Length; i++)
          {
                    result[i] = inArray[inArray.Length - 1 - i];
          }
          return result;
}

// А если текущий массив больше не нужен, то можно перевернуть элементы внутри этого же массива, без создания нового.
void ReverseArray2(int[] inArray)
{
          for (int i = 0; i < inArray.Length / 2; i++)
          {
                    int temp = inArray[i];
                    inArray[i] = inArray[inArray.Length - 1 - i];
                    inArray[inArray.Length - 1 - i] = temp;
          }
}