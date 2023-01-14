// Задача 27: Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
using static System.Console;
Clear();
Write("Введите число: ");
int num = Convert.ToInt32(ReadLine());
int sum = SumNumbers(num);
WriteLine($"Сумма чисел {num} = {sum}");

int SumNumbers(int number)
{
          int result = 0;
          while(number > 0)
          {
                    result += number%10;
                    number /= 10; 
          }
          return result;
}