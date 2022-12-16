using static System.Console;

WriteLine("Введите число от 1 до 7: ");
int a = int.Parse(ReadLine()!);


if (a == 1)
{
          WriteLine($"День недели - понедельник");
}
else if (a == 2)
{
          WriteLine($"День недели - вторник");
}
else if (a == 3)
{
          WriteLine($"День недели - среда");
}
else if (a == 4)
{
          WriteLine($"День недели - четверг");
}
else if (a == 5)
{
          WriteLine($"День недели - пятница");
}
else if (a == 6)
{
          WriteLine($"День недели - суббота");
}
else if (a == 7)
{
          WriteLine($"День недели - воскресенье");
}
else
{
          WriteLine($"Введено неверное число");
}