// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numbersForSort = new int[]
{
    4, 3, 2, 1, 7, 9, 5
};

for (int j = 0; j < numbersForSort.Length; j++)
{
    int min = numbersForSort[j];
    int iterator = j;

    for (int i = j; i < numbersForSort.Length; i++)
    {
        if (numbersForSort[i] < min)
        {
            min = numbersForSort[i];
            iterator = i;
        }
    }

    int buffer = numbersForSort[j];
    numbersForSort[j] = min;
    numbersForSort[iterator] = buffer;
}

