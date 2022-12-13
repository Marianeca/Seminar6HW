// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 

double k1, b1, k2, b2;

Console.WriteLine($"Задайте число 1: ");
double.TryParse(Console.ReadLine()!, out k1);
Console.WriteLine($"Задайте число 2: ");
double.TryParse(Console.ReadLine()!, out b1);
Console.WriteLine($"Введите число 3: ");
double.TryParse(Console.ReadLine()!, out k2);
Console.WriteLine($"Задайте число 4: ");
double.TryParse(Console.ReadLine()!, out b2);

if (k1 != k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"{x};{y}");
}
else

    Console.WriteLine($"Заданные прямые не пересекаются.");




