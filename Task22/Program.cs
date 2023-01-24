// Задача 22.
// Напишите программу, которая 
// принимаетна вход число (N) 
// и выводит таблицу квадратов
// чисел от1 до N

// 5 -> 1,4,9,16,25.
// 2 -> 1,4

// Пример таблицы
// 1  1
// 2  4
// 3  9
// 4  16
// 5  25

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Некорректный ввод" );
else Table(number);

void Table(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,5} {count * count,5}");
        count++;
    }
}
