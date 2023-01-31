// **Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
using static System.Console;
Clear();

Write("Введите число M и N через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);

WriteLine($"Все натуральные числа в промежутке от {parameters[0]} до {parameters[1]} -> {GetNumbers(parameters[0], parameters[1])}");
PrintNumbers(parameters[0], parameters[1]);

string GetNumbers(int minValue, int maxValue)
{
          return (maxValue == minValue)?maxValue.ToString():$"{GetNumbers(minValue, maxValue-1)}, {maxValue}";
}

void PrintNumbers(int minValue1, int maxValue1)
{
          if(maxValue1 == minValue1) Write(maxValue1);
          else
          {
                    PrintNumbers(minValue1, maxValue1 -1);
                    Write($", {maxValue1}");
          }
}
