// Нахождения максимума из 9 массива

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int len = col.Length;
    int position = 0;
    while (position < len)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int[] arr = new int[9];

FillArray(arr);
PrintArray(arr);

// Console.WriteLine(max);
