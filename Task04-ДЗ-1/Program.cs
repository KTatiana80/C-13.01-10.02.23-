﻿// Задача 4: 
// Напишите программу, которая 
// принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите целое число1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число3: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max ) max = b;
if (c > max ) max = c;

Console.Write("max = ");
Console.WriteLine(max);