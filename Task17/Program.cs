// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
using static System.Console;
Clear();

WriteLine("Введите номер координатной четверти от 1 до 4: ");
int a = Convert.ToInt32(ReadLine());

// Конструкция SwitchCase. Конструкция switch/case оценивает некоторое выражение и сравнивает его значение с набором значений.
// И при совпадении значений выполняет определенный код.

switch (a)
{
          case 1:
          {
                 WriteLine("x > 0, y > 0");
                 break;   
          }
          case 2:
          {
                 WriteLine("x < 0, y > 0");
                 break;   
          }
          case 3:
          {
                 WriteLine("x < 0, y < 0");
                 break;   
          }
          case 4:
          {
                 WriteLine("x > 0, y < 0");
                 break;   
          }
          default:
          {
                 WriteLine("Введено неверное число четверти");
                 break;   
          }
}

// if( a < 1 || a > 4)
// {
//           WriteLine("Введено неверное число четверти");
//           return;
// }
// if (a == 1)
// {
//           WriteLine("x > 0, y > 0");
// }
// if (a == 2)
// {
//           WriteLine("x < 0, y > 0");
// }
// if (a == 3)
// {
//           WriteLine("x < 0, y < 0");
// }
// if (a == 4)
// {
//           WriteLine("x > 0, y < 0");
// }
