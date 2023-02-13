var rand = new Random();
int Strings = rand.Next(2,4);
int Columns = rand.Next(4,8);
int[,] Array1 = new int[Strings,Columns];
int[,] Array2 = new int[Strings,Columns];
int[,] ArrayResult = new int[Strings,Columns];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = NewUniqueNum(arr);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],5}");
        }
    }
    Console.WriteLine();
}


int NewUniqueNum(int[,] array)
{
    int newNum = rand.Next(1,101);
    foreach (int num in array)
    {
        if (num == newNum)
        {
            NewUniqueNum(array);
        }
    }
    return newNum;
}

FillArray(Array1);
FillArray(Array2);
PrintArray(Array1);
PrintArray(Array2);

for (int i = 0; i < ArrayResult.GetLength(0); i++)
{
    for (int j = 0; j < ArrayResult.GetLength(1); j++)
    {
        ArrayResult[i,j] = Array1[i,j] * Array2[i,j];
    }
}


PrintArray(ArrayResult);