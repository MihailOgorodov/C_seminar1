// **Задача 63:** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
using static System.Console;
Clear();

// Рекурсивный сбор строки и её вывод
string result = GetNumbers(10);
WriteLine(result);
string GetNumbers(int num)
{
          if (num == 1) return num.ToString(); // ToString - все, что слева, преобразуется в строку
          else return $"{GetNumbers(num - 1)},{num}";
}
// Такой же сбор строки и её вывод, но через тернарный оператор
string result1 = GetNumbers1(10);
WriteLine(result1);
string GetNumbers1(int num)
{
          return (num == 1) ? num.ToString() : $"{GetNumbers1(num - 1)},{num}";
}
// Рекурсивный сбор каждого элемента и поочередный их вывод
PrintNumbers(10);
void PrintNumbers(int num)
{
          if (num == 1) Write(num);
          else
          {
                    PrintNumbers(num - 1);
                    Write($",{num}");
          }
}