int ParseText(string text)
{
    Console.WriteLine(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}
void FillMatrix(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(1); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < Matrix.GetLength(0); j++)
        {
            Matrix[j, i] = new Random().Next(0, 10);
            Console.Write(Matrix[j, i]);
        }
    }

}

int SummRows(int[,] Matrix, int Rows)
{
    int resultSumm = 0;
    for (int i = 0, result = 0; i < Matrix.GetLength(0); i++)
    {
        result = result + Matrix[i, Rows];
        resultSumm = result;
    }
    return resultSumm;

}
/*
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

// int[,] Matrix = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

// void PrintMartix()
// {
//     for (int j = 0; j < Matrix.GetLength(0); j++)
//     {
//         Console.WriteLine();
//         for (int i = 0; i < Matrix.GetLength(1); i++)
//         {
//             Console.Write(Matrix[j,i]);
//         }
//     }
// }
// void MatrixReorganiz(int rows)

// {
//     for (int k = 0; k <= Matrix.GetLength(0); k++)
//     {
//         for (int i = 1, h = 0, Max = 0; i <= Matrix.GetLength(0); h++, i++)
//         {

//         if (Matrix[rows, h] < Matrix[rows, i])
//         {
//             Max = Matrix[rows, i];
//             Matrix[rows, i] = Matrix[rows, h];
//             Matrix[rows, h] = Max;

//         }

//         }
//     }
// }
// for (int n = 0; n < Matrix.GetLength(0); n++)
// {
// MatrixReorganiz(n);
// }
// PrintMartix();    

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


// int rows = ParseText("введите строк");
// int column = ParseText("введите столбцов");

// int[,] Matrix2 = new int[column, rows];

// FillMatrix(Matrix2);



// int minIndex = 0;
// for (int h = 0, minSumm = SummRows(Matrix2,0); h < Matrix2.GetLength(0); h++)
// {

//     if (SummRows(Matrix2, h) < minSumm)
//     {
//         minIndex = h;
//     }

// }
// Console.WriteLine();
// Console.WriteLine("Строка с наименьшей суммой элементов: "+(minIndex+1));


/*
Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение двух массивов (поэлементное).
Например, даны 2 массива:
2 4
3 2

3 4
3 3
Результирующая матрица будет:
6 16
9 6
*/

// int column = ParseText("Введите количество строк двух массивов");
// int rows = ParseText("Введите количество столбцов двух массивов");
// int[,] Matrix2 = new int[column, rows];
// int[,] Matrix3 = new int[column, rows];
// FillMatrix(Matrix2);
// Console.WriteLine();
// FillMatrix(Matrix3);
// for (int i = 0; i < Matrix3.GetLength(0); i++)
// {
//     Console.WriteLine();
//     for (int j = 0; j < Matrix3.GetLength(1); j++)
//     {
//         Matrix3[j,i] *= Matrix2[j,i];
//         Console.Write(Matrix3[j,i]+"  "); 
//     }
// }


/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

// void FillMatrix3d(int[,,] Matrix)
// {
//     for (int i = 0; i < Matrix.GetLength(2); i++)
//     {
//         Console.WriteLine();
//         for (int k = 0; k < Matrix.GetLength(0); k++)
//         {
//             Console.WriteLine();
//             for (int j = 0; j < Matrix.GetLength(1); j++)
//             {
//                 Matrix[k, j, i] = new Random().Next(10, 99);
//                 Console.Write(Matrix[k, j, i]+"("+k+","+j+","+i+ ")");
//             }
//         }
//     }

// }
// int x = ParseText("введите ширину трехмерного массива");
// int y = ParseText("введите длинну трехмерного массива");
// int z = ParseText("введите глубину трехмерного массива");
// int[,,] Matrix3d = new int[x, y, z];
// FillMatrix3d(Matrix3d);

/*
Доп.Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
