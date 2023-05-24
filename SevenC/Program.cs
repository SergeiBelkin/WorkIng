﻿/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами 
от -10,0 до 10,0.

m = 3, n = 4.

0,5 7,0 -2,0 -0,2

1,0 -3,3 8,0 -9,9

8,0 7,8 -7,1 9,0
*/
Console.WriteLine("Введите колличество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());

int a = new Random().Next(-10, 10);
MassFilling(m,n);
double[,]mass = new double[m, n];

double MassFilling(int rows, int columns)
{
    for (int i = 0; i <= rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            mass[i,j] = 0;
        }
    }
    return mass[,]; 
}

Console.WriteLine (a);



/*
Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в
 двумерном массиве или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/



/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/