﻿/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] Matrix = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

void PrintMartix()
{
    for (int j = 0; j <= Matrix.GetLength(1); j++)
    {
        for (int i = 0; i <= Matrix.GetLength(0); i++)
        {
            Console.Write(Matrix[i,j]);
        }
    }
}
void MatrixReorganiz(int rows)

{
    for (int k = 0; k <= Matrix.GetLength(0); k++)
    {

     
    for (int i = 1, h = 0, Max = 0; i <= Matrix.GetLength(0); h++, i++)
    {
        
        if (Matrix[rows, h] < Matrix[rows, i])
        {
            Max = Matrix[rows, i];
            Matrix[rows, i] = Matrix[rows, h];
            Matrix[rows, h] = Max;
            
        }

    }
    }
}
for (int i = 0; i <= Matrix.GetLength(1); i++)
{
    MatrixReorganiz(i);

}
PrintMartix();    
    


