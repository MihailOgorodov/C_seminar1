// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
using static System.Console;
Clear();

Write("Input number: ");
int number = Convert.ToInt32(ReadLine());
int multiply = GetMultiply (number);
WriteLine($"Multiply  number from 1 to {number} = {multiply}");


int GetMultiply (int A)
{
          int result = 1;
          while (A > 0)
          {
                    result *= A;
                    A--;
          }

          return result;
}