﻿// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.  5, 25 -> да  //  4, 16 -> да //  25, 5 -> да  //  8,9 -> нет
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
int num3 = num1 * num1;
int num4 = num2 * num2;
if(num1 == num4 || num2 == num3)
{
  Console.Write("Да ");
}
else
{
  Console.Write("Нет ");
}