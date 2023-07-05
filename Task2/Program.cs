// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите число А:");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число В:");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Большее число: {numberA}");
    Console.WriteLine($"Меньшее число: {numberB}");
}
if (numberA < numberB)
{
    Console.WriteLine($"Большее число: {numberB}");
    Console.WriteLine($"Меньшее число: {numberA}");
}
else
Console.WriteLine($"Числа равны! число А ({numberA}) = число В ({numberB})");