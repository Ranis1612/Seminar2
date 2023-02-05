// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 // 16, 4 -> кратно
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
int num = (num2 / num1);
int ost = num2 % num1;
if(num2 == num * num1)
{
  Console.WriteLine($"{num2} кратно {num1}");
}
else if(num1 > num2)
{
  Console.WriteLine("Задача не имеет решения т.к первое число больше второго");
  return;
}
else
{
  Console.WriteLine($"{num2} не кратно {num1}");
  Console.WriteLine($" остаток {ost}");
};
