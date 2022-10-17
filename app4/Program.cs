

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetNumberValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = GetNumberValue(minValue, maxValue);
        }
    }
}

int SumCentralDiagonal(int[,] arr)
{   
    int sum =0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            
            if (i == j)
            {
                sum+=arr[i,j];
            }
        }
    }
    return sum;
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] InitializateArray(int m, int n)
{
    return new int[m, n];
}

int m = GetNumberFromConsole("Введите размерность массива: m");
int n = GetNumberFromConsole("Введите размерность массива: n");
int[,] array = InitializateArray(m, n);
int maxValue = GetNumberFromConsole("Введите максимальное допустимое число в массиве:");
int minValue = GetNumberFromConsole("Введите минимальное допустимое число в массиве:");
FillArray(array, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(SumCentralDiagonal(array));

