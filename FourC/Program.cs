/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/


// int PozitivSumm = 0;
// string EndedText = " ";
// while (EndedText == " ")
// {

//     Console.WriteLine("введите число или введите end для завершения");
//     string EnteredText = Console.ReadLine();

//     if (EnteredText == "end")
//     {
//         EndedText = EnteredText;
//         break;
//     }
//     int a = int.Parse(EnteredText);
//     if (a > 0)
//     {
//         PozitivSumm++;
//     }


// }
// Console.WriteLine(PozitivSumm);

/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 

y = k1 * x + b1, y = k2 * x + b2; 

значения b1, k1, b2 и k2 задаются пользователем.

Формулы нахождения координат x и y точки пересечения:
x = (b2-b1)/(k1-k2);
y = k1*x+b1;

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

// Console.WriteLine("Введите первое значение первой прямой");
// double K1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе значение первой прямой");
// double B1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Введите первое значение второй прямой");
// double K2 = double.Parse(Console.ReadLine());

// Console.WriteLine("Введите тророе значение второй прямой");
// double B2 = double.Parse(Console.ReadLine());

// double x = (B2 - B1) / (K1 - K2);

// double y = K1 * x + B1;
// Console.WriteLine($"координаты точки пересечения прямых х = {Math.Round(x,2)} y = {Math.Round(y,2)}");
