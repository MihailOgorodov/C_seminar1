// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А, которые делятся на А без остатка.
using static System.Console;
Clear();

Write("Input number: ");
int number = Convert.ToInt32(ReadLine());
int sum = GetSum(number);
WriteLine($"Sum number from 1 to {number} = {sum}");


int GetSum(int A)
{
          int result = 0;
          int temp = A;
          while (A > 0)
          {
                    if (temp % A == 0)
                    {
                              result += A;
                    }
                    A--;
          }

          return result;
}
