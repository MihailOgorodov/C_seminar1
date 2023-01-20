// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
using static System.Console;
Clear();

WriteLine("Введите число: ");
int a = Convert.ToInt32(ReadLine());
PrintArray(Fibonacci(a));

int[] Fibonacci(int number)
{
          int[] resultArray = new int[number];
          resultArray[0] = 0;
          resultArray[1] = 1;
          for (int i = 2; i < number; i++)
          {
                    resultArray[i] = resultArray[i - 1] + resultArray[i - 2];
          }
          return resultArray;
}


void PrintArray(int[] inArray)
{
          for (int i = 0; i < inArray.Length - 1; i++)
          {
                    Write($"{inArray[i]},");
          }
          Write($"{inArray[inArray.Length - 1]}");
}

// using static System.Console;
// Clear();

// Write("Введите число: ");
// int number = int.Parse(ReadLine()!);
// Fibonachi(number);

// void Fibonachi(int number)
// {
// int temp, num1 = 0, num2 = 1;
// Write($"{num1} {num2} ");
// for (int i = 2; i < number; i++)
// {
// temp = num1 + num2;
// num1 = num2;
// num2 = temp;
// Write($"{num2} ");
// }
// }

// int a = 10;
//WriteLine(Convert.ToString(a,2));