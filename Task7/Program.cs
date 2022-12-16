using static System.Console;

WriteLine("Введите трехзначное число: ");
int a = int.Parse(ReadLine()!);

WriteLine($"Последняя цифра этого числа {a%10}");