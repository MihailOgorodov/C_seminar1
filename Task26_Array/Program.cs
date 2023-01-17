// Инициализация массива из 10 элементов
// int[] ArrayName = {12,5,5,8,9,14};
// int[] ArrayName = new int[10];

// Наполнение массива вводом с консоли

// for (int i = 0; i < ArrayName.Lenght; i++)
// {
//          ArrayName[i]=int.Parse(ReadLine()); 
// }

// Считывание массива

// WriteLine(ArrayName[2]);

// Написание методов через массив данных
// int[] GetArray()
// {
//           int[] res = new int[8];
//           return res ;

// }

// Вывод метода массив, который выводит массив в 1 строку
// void PrintArray(int[] inArray)
// {

// }

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]

// using static System.Console;
// Clear();

// int[] arr = new int[8];
// PrintArray(arr);

// void PrintArray(int[] array)
// {
//           int count = array.Length;
//           for (int i = 0; i < count; i++)
//           {
//                     Write($"{new Random().Next(0, 2)} ");
//           }

// }

using static System.Console;
Clear();

int[] arr = GetArray(4);
int[] arr1 = new int[8];



PrintArray(arr);



// void FullArray(int[] array)
// {
//           for (int i = 0; i < array.Length; i++)
//           {
//                     array[i] = new Random().Next(0, 2);
//           }
// }

int[] GetArray(int size)
{
          int[] array = new int[size];
          for (int i = 0; i < array.Length; i++)
          {
                    array[i] = new Random().Next(2);
          }
          return array;
}

void PrintArray(int[] array)
{
          for (int i = 0; i < array.Length; i++)
          {
                    WriteLine($"{array[i]} ");
          }
}