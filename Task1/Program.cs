using static System.Console;

WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);

WriteLine("Введите число: ");
int b = int.Parse(ReadLine()!);

if (a == b * b)
{
          WriteLine($"Число {a} является квадратом числа {b}");
}
else
{
          WriteLine($"Число {a} не является квадратом числа {b}");
}