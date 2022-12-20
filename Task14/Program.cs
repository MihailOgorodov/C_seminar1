// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
using static System.Console;
Clear();

WriteLine("Введите число: ");
int a = Convert.ToInt32(ReadLine());

WriteLine(a%7==0&&a%23==0?"кратно 7 и 23":"не кратно 7 и 23");
