﻿// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// ( НЕОБЯЗАТЕЛЬНАЯ)


Console.WriteLine("Введите поочередно три числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a < b+c && b < a+c && c <a+b)
{
    Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} - может существовать!");
}
else Console.WriteLine("К сожалению, такого треугольника не может существовать!");