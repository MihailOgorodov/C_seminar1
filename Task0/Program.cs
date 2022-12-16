using static System.Console;

WriteLine("Введите число: ");

int a = int.Parse(ReadLine()!); // Преобразование сторчных данных в число
// int b = Convert.ToInt32(ReadLine()); // Преобразование любых типов данных в число

WriteLine($"Квадрат числа {a} равен {a*a}");