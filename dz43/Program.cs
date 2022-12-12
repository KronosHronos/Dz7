Console.Clear();

Console.Write("Введите количество строк массива:");
int m = int.Parse(Console.ReadLine()?? "");

Console.Write("Введите количество столбцов массива:");
int n = int.Parse(Console.ReadLine()?? "");

double[,] array = GetArray(m, n, -100, 100);
PrintArray(array);

double[,] GetArray (int m, int n, int minValue, int maxValue)
{
    double[,] resultArray = new double[m,n];
    for (int i =0; i< m; i++)
    {
        for (int j=0; j < n; j++)
        {
           double result = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
           resultArray[i, j] = Math.Round(result, 2); 
        }
    }
    return resultArray;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}
