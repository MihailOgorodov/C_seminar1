// Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B с использованием цикла.
using static System.Console;
Clear();

Write("Введите первое число: ");
int A = Convert.ToInt32(ReadLine());
Write("Введите второе число: ");
int B = Convert.ToInt32(ReadLine());

int expo = Exponent(A, B);
WriteLine($"Число {A} в степени {B} = {expo}");

int Exponent(int firstNum, int secondNum)
{
          int count = 1;
          int result = 1;
          if(secondNum < 0)
          {
                    secondNum *= -1; 
          }
          while (count <= secondNum)
          {
                    result *= firstNum;
                    count++;                        
          }
          return result;
}