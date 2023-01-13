// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
using static System.Console;
Clear();

Write("Input number: ");
int number = Convert.ToInt32(ReadLine());
int sum = SumNumbers(number);
WriteLine($"Количество числ в числе {number} = {sum}");

// int SumNumbers(int A)
// {
//           int result = 0;
//           if (A > 0 && A < 10)
//           {
//                     result = 1;
//           }
//           else if (A >= 10 && A < 100)
//           {
//                     result = 2;
//           }
//           else if (A >= 100 && A < 1000)
//           {
//                     result = 3;
//           }
//           else if (A >= 1000 && A < 10000)
//           {
//                     result = 4;
//           }
//           else if (A >= 10000 && A < 100000)
//           {
//                     result = 5;
//           }
//           return result;

// }

int SumNumbers(int A)
{
          int digits = 0;
          while (A > 0)
          {
                    A /= 10;
                    digits++;
          }

          return digits;
}