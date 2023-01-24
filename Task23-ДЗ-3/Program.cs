// Задача 23
// Напишите программу, которая принимает
// на вход число (N) и выдаёт
// таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Tablecubes(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,5} {count * count * count,5}");
        count++;
    }
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Таблица кубов");

if (number < 1) Console.WriteLine("Некорректный ввод" );
else Tablecubes(number);

// Console.WriteLine("Таблица кубов");


