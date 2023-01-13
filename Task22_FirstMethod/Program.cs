// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// Значит метод будет из 4 группы - и принимает и выдает.
// Выдает число, значит начинается с int.
using static System.Console;
Clear();

Write("Input number: ");
int number = Convert.ToInt32(ReadLine());
int sum = GetSum(number);
WriteLine($"Sum number from 1 to {number} = {sum}");


int GetSum(int A)
{
          int result = 0;
          while (A > 0)
          {
                    result += A; // result = result + A. Так же работает с -=, /=, *=
                    A--;
          }

          return result;
}