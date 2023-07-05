// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите число А:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число В:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число C:");
int c = int.Parse(Console.ReadLine());

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write($"Максимальным числом является число ({max})");