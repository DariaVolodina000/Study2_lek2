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

int IndexOf(int[] array, int find)
{
    int lengt = array.Length;
    int index = 0;
    int positi = -1;
    while (index < lengt)
    {
        if (array[index] == find)
        {
            positi = index; 
            break;
        }
       
        index++;
    }
    return positi;
}

int[] arr = new int[9];

FillArray(arr);
PrintArray(arr);
Console.WriteLine();
int pos = IndexOf(arr, 4);
Console.WriteLine(pos);

// Console.WriteLine(max);
