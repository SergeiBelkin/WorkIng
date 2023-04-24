int[,] mrx = new int[5,8];
int getRandom()
{
    int x = 0;
    x = new Random().Next(1,100);
    return x;
}
int[,] matrix(int rows, int columns)
{
for (int c = 0; c < mrx.GetLength(1); c++)
{
    for (int r = 0; r < mrx.GetLength(0); r++)
    {
        mrx[r,c] = getRandom();
    }
    
}
return mrx;
}
void printMat(int row, int column)
{
for (int c = 0; c < mrx.GetLength(1); c++)
{
    for (int r = 0; r < mrx.GetLength(0); r++)
    {
        Console.Write($"  {mrx[r,c]}  ");
    }
    Console.WriteLine();
}
}
int row = mrx.GetLength(1);
int column = mrx.GetLength(0);
matrix( row, column);
printMat( row, column);



