var rand = new Random();
int[,] SomeArray = new int[2,rand.Next(2,11)];
void FillArray(int[,] arr)
{
    for (int i = 0; i < SomeArray.GetLength(0); i++)
    {

        for (int j = 0; j < SomeArray.GetLength(1); j++)
        {
            SomeArray[i, j] = rand.Next(1, 101);
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

FillArray(SomeArray);
PrintArray(SomeArray);
int TotalElements = SomeArray.GetLength(0) * SomeArray.GetLength(1);
int CurrentString = 0;
int CurrentColumn =0;

for (int i = 0; i < TotalElements; i++)
{
    if (CurrentColumn == SomeArray.GetLength(1))
    {
        CurrentString++;
        CurrentColumn = 0;
    }
    int max = SomeArray[CurrentString,CurrentColumn];
    int MaxString = CurrentString;
    int MaxColumn = CurrentColumn;
    int tempNum = SomeArray[CurrentString,CurrentColumn];
    for (int j = CurrentColumn; j < SomeArray.GetLength(1); j ++)
    {
        if (max < SomeArray[CurrentString,j])
        {
            max = SomeArray[CurrentString,j];
            MaxString = CurrentString;
            MaxColumn = j;
        }
    }
    SomeArray[CurrentString,CurrentColumn] = max;
    SomeArray[MaxString,MaxColumn] = tempNum;
    CurrentColumn++;
}

PrintArray(SomeArray);