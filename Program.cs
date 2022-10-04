/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */
int a;
Console.WriteLine("Введите число");
while (!int.TryParse(Console.ReadLine(), out a))
{
	Console.WriteLine("Не верный ввод. Повторите ввод");
}

if (a % 2 == 0)
{
	Console.WriteLine("Число четное");
}
else
{
	Console.WriteLine("Число нечетное");
}
