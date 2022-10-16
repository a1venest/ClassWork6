// Задача 48: Задайте двумерный массив размера
// m на n, каждый элемент в массиве находится по
// формуле: Aₘₙ = m+n. Выведите полученный
// массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] arr)
{
    for(int i = 0; i<arr.GetLength(0) ; i++)
    {
        for(int j =0;j<arr.GetLength(1) ;j++)
        {
            arr[i,j] = i+j;
        }
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i<arr.GetLength(0) ; i++)
    {
        for(int j =0;j<arr.GetLength(1) ;j++)
        {
            Console.Write(arr[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}

int m = GetNumberFromConsole("Введите размерность массива: m");
int n = GetNumberFromConsole("Введите размерность массива: n");
int[,] array = InitializateArray(m,n);
FillArray(array);
PrintArray(array);