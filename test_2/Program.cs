/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
между ними в 3D пространстве. */

Console.WriteLine("Введите координату xA:");
int xA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату yA:");
int yA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату zA:");
int zA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату xB:");
int xB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату yB:");
int yB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату zB:");
int zB = int.Parse(Console.ReadLine()!);

Console.WriteLine($" xA = {xA}, xB = {xB}, yA = {yA}, yB =  {yB}, zA = {zA}, zB = {zB}");

double length = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));

Console.WriteLine($" Расстояние между двумя точками выносит {length}");