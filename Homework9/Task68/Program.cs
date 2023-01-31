// Задача 68: Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
using static System.Console;
Clear();
Write("Введите число m: ");
int m = Convert.ToInt32(ReadLine());
Write("Введите число n: ");
int n = Convert.ToInt32(ReadLine());

WriteLine(AccermanNumbers(m, n));

int AccermanNumbers(int firstNum, int secondNum)
{
          if (firstNum == 0) return secondNum + 1;
          else if (firstNum > 0 && secondNum == 0) return AccermanNumbers(firstNum - 1, 1);
          else return AccermanNumbers(firstNum - 1, AccermanNumbers(firstNum, secondNum - 1));
}