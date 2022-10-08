// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
using static System.Console;
Clear();
Write("введите размер матрицы и минимальный и максимальное значение через пробел: ");
int[] parametrs = GetArrayFromString(ReadLine());
int[,] matrix = GetMatrixArray(parametrs[0], parametrs[1], parametrs[2], parametrs[3]);
PrinttMatrix(matrix);
Write("введите  через номер строки и столбца искомого элемента ");
int[] findElement = GetElement(ReadLine());
if (findElement[0] >= parametrs[0] || findElement[0] <= 0 & findElement[1] >= parametrs[1]||findElement[1]<=0)
    WriteLine("Введена параметры превышающие границы данного массива");
else
    Write(matrix[findElement[0], findElement[1]]);






int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return resultMatrix;
}
void PrinttMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]} ");
        }
        WriteLine();
    }
}
int[] GetArrayFromString(string parameters)
{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parameterNum = new int[parames.Length];
    for (int i = 0; i < parameterNum.Length; i++)
    {
        parameterNum[i] = int.Parse(parames[i]);
    }
    return parameterNum;
}


int[] GetElement(string rowColumnFindElement)
{
    string[] rowColumn = rowColumnFindElement.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] rowColumnNum = new int[rowColumn.Length];
    for (int i = 0; i < rowColumnNum.Length; i++)
    {
        rowColumnNum[i] = int.Parse(rowColumn[i]) - 1;
    }
    return rowColumnNum;
}