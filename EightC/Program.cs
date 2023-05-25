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

int SummRows(int[,]Matrix,int Rows)
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

int column = ParseText("Введите количество строк двух массивов");
int rows = ParseText("Введите количество столбцов двух массивов");
int[,] Matrix2 = new int[column, rows];
int[,] Matrix3 = new int[column, rows];
FillMatrix(Matrix2);
Console.WriteLine();
FillMatrix(Matrix3);
for (int i = 0; i < Matrix3.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < Matrix3.GetLength(1); j++)
    {
        Matrix3[j,i] *= Matrix2[j,i];
        Console.Write(Matrix3[j,i]+"  "); 
    }
}

