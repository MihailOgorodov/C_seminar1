// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да
using static System.Console;
Clear();
Write("Введите число: ");
int a = Convert.ToInt32(ReadLine());

int[] FirstArray = GetArray(10);
PrintArray(FirstArray);

//bool result = ArrayLookUp(FirstArray, a);
WriteLine(ArrayLookUp(FirstArray, a)?" Да":" Нет");



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
          Write("массив [");
          for (int i = 0; i < inArray.Length - 1; i++)
          {
                    Write($"{inArray[i]},");
          }
          Write($"{inArray[inArray.Length - 1]}]");
}

bool ArrayLookUp(int[] inArray1, int number)
{
          foreach (var i in inArray1)
          {
                    if(number == i) return true;
                    
          }
          return false;
}