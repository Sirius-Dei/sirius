﻿//Напишите программу, которая на вход три числа и выдает максимальное из этих чисел

Console.WriteLine("Enter first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter third number");
int c = int.Parse(Console.ReadLine());
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($"Maximal = {max}");