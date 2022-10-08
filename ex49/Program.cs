// **Задача 49:** Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:
using static System.Console;
Clear();
Write("введите размер матрицы и минимальный и максимальное значение через пробел: ");
int[] parametrs=GetArrayFromString(ReadLine());
double[,]matrix=GetMatrixArray(parametrs[0], parametrs[1], parametrs[2], parametrs[3]);
PrinttMatrix(matrix);
WriteLine();
PrinttMatrix2(matrix);








double[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] resultMatrix= new double[rows, columns];
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        resultMatrix[i,j]= new Random().Next(minValue, maxValue);
    }
}
return resultMatrix;
}
void PrinttMatrix(double[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i,j]}\t");
        }
        WriteLine();
    }
}
int[] GetArrayFromString(string parameters) 
{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parameterNum=new int[parames.Length];
    for (int i = 0; i < parameterNum.Length; i++) 
    {
        parameterNum[i]=int.Parse(parames[i]);
    }
    return parameterNum;
}
void PrinttMatrix2(double[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            if(i%2==0&&j%2==0)
            {
                inMatrix[i,j]=Math.Pow(inMatrix[i,j], 2);
            }
            Write($"{inMatrix[i,j]}\t");
        }
        WriteLine();
    }
}
