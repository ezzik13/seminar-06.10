// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
using static System.Console;
Clear();
Write("введите размер матрицы и минимальный и максимальное значение через пробел: ");
int[] parametrs=GetArrayFromString(ReadLine());
int[,]matrix=GetMatrixArray(parametrs[0], parametrs[1], parametrs[2], parametrs[3]);
PrinttMatrix(matrix);
WriteLine();
double[] ArithmeticMean=GetArithmeticMean(matrix);
PrintArray(ArithmeticMean);








int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix= new int[rows, columns];
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        resultMatrix[i,j]= new Random().Next(minValue, maxValue);
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
            Write($"{inMatrix[i,j]}\t ");
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

double[] GetArithmeticMean(int[,] inMatrix)
{
    double[] arithmeticMean=new double[inMatrix.GetLength(1)];
    

    for (int i = 0; i < inMatrix.GetLength(1); i++)
    {
        double sum=0;
        for (int j = 0; j < inMatrix.GetLength(0); j++)
        {
            sum=sum+inMatrix[j,i];
        }
        arithmeticMean[i]=Math.Round(sum/inMatrix.GetLength(0),2);
    }
    return arithmeticMean;
}
void PrintArray(double[] inArray)
{
for(int i=0;i<inArray.Length-1;i++)
{
    Write($"{inArray[i]}      ");
}
WriteLine($"{inArray[inArray.Length-1]}");
}