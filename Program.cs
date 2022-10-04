/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */
int a;
int i = 1;
Console.WriteLine("Введите число");
while (!int.TryParse(Console.ReadLine(), out a))
{
	Console.WriteLine("Не верный ввод. Повторите ввод");
}
while (i <= a)
{
	if (i % 2 == 0)
	{
		Console.Write(i + ", ");
	}
	i++;
}
