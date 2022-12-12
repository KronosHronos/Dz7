int m = GetUserNumber("Введите число строк массива: ", "Ошибка ввода!");   
int n = GetUserNumber("Введите число столбцов массива: ", "Ошибка ввода!");

int[,] array = GetArray(m, n, -100, 100);       
PrintArray(array);
double[] result = average (array);
Console.WriteLine("----------------------------------");
Console.WriteLine(String.Join("; ", result));

int GetUserNumber(string messageToUser, string errorMessage)
{
    while (true)
    {
        Console.Write(messageToUser);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] resultArray = new int[m,n];
    for (int i =0; i< m; i++)
    {
        for (int j=0; j < n; j++)
        {
           resultArray[i,j]=new Random().Next(minValue, maxValue + 1);
           
        }
    }
    return resultArray;
}

void PrintArray(int[,] inArray)
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

double[] average(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];
    double count = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            count += (double)inArray[j, i];
        }
        result[i] = Math.Round((double)count / inArray.GetLength(0), 2);  

        count = 0;
    }
    return result;
}