﻿/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/

Console.Write("Введите число 1 :_ ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 :_ ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3 :_ ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max){    
    max = number2; 
}

if (number3 > max){    
    max = number3; 
}

Console.WriteLine(max + " - Максимальное число");