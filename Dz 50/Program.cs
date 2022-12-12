int m = new Random().Next(2, 15);                   
int n = new Random().Next(2, 15);

int row = GetUserNumber("Введите номер строки элемента: ", "Ошибка ввода!");
int column = GetUserNumber("Введите номер столбца элемента: ", "Ошибка ввода!");


double[,] array = GetArray(m, n, -100, 100);       
PrintArray(array);
string result = CheckingIfElementExists(array, row, column);
Console.WriteLine("----------------------------------");
Console.WriteLine(result);

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

string CheckingIfElementExists(double[,] inArray, int row, int column)
{
    string result = $"элемента с позицией {row},{column} нет в массиве";
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == row - 1 && j == column - 1)
            {
                result = $"{row},{column} -> {inArray[i, j]}";
                break;
            }
        }
    }
    return result;
}