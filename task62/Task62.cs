var rand = new Random();
int[,] SomeArray = new int[4,4];
int TotalElements = SomeArray.GetLength(0) * SomeArray.GetLength(1) + 1;
int UpperBorder = 0;
int LeftBorder = 0;
int RightBorder = SomeArray.GetLength(1) - 1;
int DownBorder = SomeArray.GetLength(0) - 1;
int num = 1;

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j],5}");
        }
    }
    Console.WriteLine();
}

PrintArray(SomeArray);
FillArray(SomeArray);


void FillArray(int[,] arr)
{
    while (num <= TotalElements)
    {   
        for (int i = LeftBorder; i <= RightBorder; i++)
        {
            SomeArray[UpperBorder,i] = num;
            num++;
        }
        if (num == TotalElements)
        {
            PrintArray(arr);
            return;
        }
        for (int j = UpperBorder + 1; j <= DownBorder; j++)
        {
            SomeArray[j,RightBorder] = num;
            num++;
        }
        UpperBorder++;
        if (num == TotalElements)
        {
            PrintArray(arr);
            return;
        }
        for (int c = RightBorder - 1 ; c >= LeftBorder; c--)
        {
            SomeArray[DownBorder,c] = num;
            num++;
        }
        RightBorder--;
        if (num == TotalElements)
        {
            PrintArray(arr);
            return;
        }
        for (int d = DownBorder - 1; d >= UpperBorder; d--)
        {
            SomeArray[d,LeftBorder] = num;
            num++;
        }
        DownBorder--;
        LeftBorder++;
        if (num == TotalElements)
        {
            PrintArray(arr);
            return;
        }
    }
}