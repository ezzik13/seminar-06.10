// **Задача 46:** Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
using static System.Console;
Clear();
Write("введите размер матрицы и минимальный и максимальное значение через пробел: ")ж
int[] parametrs=GetArrayFromString(ReadLine());
int[,]matrix=GetMatrixArray(parametrs[0], parametrs[1], parametrs[2], parametrs[3]);
PrinttMatrix(matrix);








int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix= new int[rows, columns];
for (int i = 0; i < resultMatrix.Length(0); i++)
{
    for (int j = 0; j < resultMatrix.Length(1); j++)
    {
        resultMatrix[i,j]= new Random().Next(minValue, maxValue)
    }
}
return resultMatrix;
}
void PrinttMatrix(int[,] inMatrix);
{
    for (int i = 0; i < inMatrix.Length[0]; i++)
    {
        for (int j = 0; j < inMatrix.Length[1]; j++)
        {
            Write($"{inMatrix[i,j]} ");
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


// sing static System.Console;
// int[,] GetMatrixArray(int rows,int columns,int minValue, int maxValue) 
// {
//     int[,] resultMatrix = new int[rows, columns];
//     for (int i = 0; i < resultMatrix.GetLength(0); i++) 
//     {
//         for (int j = 0; j < resultMatrix.GetLength(1); j++) 
//         {
//             resultMatrix[i,j]=new 
// void PrintMatrix(int[,] inMatrix) 
// {
//     for (int i = 0; i < inMatrix.GetLength(0); i++) 
//     {
//         for (int j = 0; j < inMatrix.GetLength(1); j++)
//         {
//             Write($"{inMatrix[i,j]} ");
//         }
//         WriteLine();
//     }
// }
