var rand = new Random();
int[,,] SomeArray = new int[rand.Next(3,6),rand.Next(3,6),rand.Next(3,6)];


void FillArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int c = 0; c < arr.GetLength(2); c++)
            {
                arr[i,j,c] = NewUniqueNum(arr);
            }
        }
    }
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int c = 0; c < arr.GetLength(2); c++)
            {
                Console.Write($"{arr[i,j,c],5}");
            }
        }
    }
    Console.WriteLine();
}


int NewUniqueNum(int[,,] array)
{
    int newNum = rand.Next(10,100);
    foreach (int num in array)
    {
        if (num == newNum)
        {
            NewUniqueNum(array);
        }
    }
    return newNum;
}

FillArray(SomeArray);
PrintArray(SomeArray);

for (int i = 0; i < SomeArray.GetLength(0); i++)
{
    for (int j = 0; j < SomeArray.GetLength(1); j++)
    {
        for (int c = 0; c < SomeArray.GetLength(2); c++)
        {
            Console.WriteLine("Элемент {0},{1},{2} значение = {3} ",i,j,c,SomeArray[i,j,c]);
        }
    }
}