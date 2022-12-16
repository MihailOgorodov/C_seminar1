// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using static System.Console;
Clear();

WriteLine("Введите число a: ");
int a = int.Parse(ReadLine()!);

WriteLine("Введите число b: ");
int b = int.Parse(ReadLine()!);

if (a > b ) 
{
          WriteLine($"Число {a} больше числа {b}");
}         
else if (a < b)
{          
          WriteLine($"Число {b} больше числа {a}");
}
else
{
          WriteLine($"Числа равны");
}