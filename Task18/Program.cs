// Задача 18. 
// Напишите программу, 
// которая по заданному номеру четверти, 
// показывает диапазон возможных координат 
// точек в этой четверти (X и Y).

Console.WriteLine("Введите ночер четверти");
string number = Console.ReadLine();

string guarter = Quarter(number);

Console.WriteLine($"{guarter}");

string Quarter(string num)
{
    // {
    //     if (num == 1) return "x > 0 и  y > 0";
    //     if (num == 2) return "x < 0 и  y > 0";
    //     if (num == 3) return "x < 0 и  y < 0";
    //     if (num == 4) return "x > 0 и  y < 0";
    //     return "Введены некорректные координаты";
    // }

    // По другому

    switch (num)
    {
        case "1": return "x > 0 и  y > 0";
        case "2": return "x < 0 и  y > 0";
        case "3": return "x < 0 и  y < 0";
        case "4": return "x > 0 и  y < 0";
        default: return "Некорректный ввод!";
    }    
}