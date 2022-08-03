// Задача 27: Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

Console.WriteLine("Введите число  ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine($"Cумма цифр в числе: " + sum);