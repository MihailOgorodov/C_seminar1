// адача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
using static System.Console;
Clear();
int num = AskUserForNumber("Введите число для перевода в двоичную систему: ");
WriteLine($"Десятичное число {num} в двоичном представлении будет {decimalToBinary(num)}");

string decimalToBinary(int inNum)
{
          if (inNum == 0) return "0";

          string result = string.Empty;
          // остаток - reminder -> var rem;
          int rem;

          while (inNum > 0)
          {
                    rem = inNum % 2;
                    inNum /= 2;
                    result = rem.ToString() + result;
          }
          return result;
}

int AskUserForNumber(string inPrompt)
{
          int resultNum = 0;
          string userInput = "";
          while (!int.TryParse(userInput, out resultNum))
          {
                    Write(inPrompt);
                    userInput = ReadLine()!;
          }
          return resultNum;
}

