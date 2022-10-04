/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

int a, b, c;
int max = a;

Console.Writeline("Введите первое число");
int.TryParse(Console.Readline(), out a);

Console.Writeline("Введите второе число");
int.TryParse(Console.Readline(), out b);

Console.Writeline("Введите третье число");
int.TryParse(Console.Readline(), out c);
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Writeline("Максимальное число " + max);