var rand = new Random();
int[,] SomeArray = new int[3,rand.Next(4,11)];
void FillArray(int[,] arr)
{
    for (int i = 0; i < SomeArray.GetLength(0); i++)
    {

        for (int j = 0; j < SomeArray.GetLength(1); j++)
        {
            SomeArray[i, j] = rand.Next(1, 11);
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
int sum = 0;
int sumMin = 0;

for (int i = 0; i < SomeArray.GetLength(0); i++)
{
    sum = 0;
    for (int j = 0; j < SomeArray.GetLength(1); j++)
    {
        sum = sum + SomeArray[i,j];
    }
    if (i == 0)
    {
        sumMin = sum;
    }
    else if (sumMin > sum)
    {
        sumMin = sum;
    }
}

Console.WriteLine("Минимальная сумма = {0}",sumMin);