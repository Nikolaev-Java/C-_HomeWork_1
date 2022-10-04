/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

int a, b, c;

Console.WriteLine("Введите первое число");
while (!int.TryParse(Console.ReadLine(), out a))
{
	Console.WriteLine("Не верный ввод. Повторите");
}

Console.WriteLine("Введите второе число");
while (!int.TryParse(Console.ReadLine(), out b))
{
	Console.WriteLine("Не верный ввод. Повторите");
}

Console.WriteLine("Введите третье число");
while (!int.TryParse(Console.ReadLine(), out c))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("Максимальное число " + max);