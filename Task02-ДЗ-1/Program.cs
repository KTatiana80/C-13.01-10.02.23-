// Задача 2: 
// Напишите программу, 
// которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите целое число1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число2: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = 0;
if (a > b)
{
    max = a;
}
else
{
    max = b;
}

Console.WriteLine($"Максимум {max}");