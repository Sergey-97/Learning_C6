/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Введите значение b1");
double b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число k1");
double k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2");
double b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число k2");
double k2 = int.Parse(Console.ReadLine()!);
Console.ResetColor ();

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"Точка пересечения двух прямых: ({x};  {y})");
Console.ResetColor ();