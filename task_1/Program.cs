Console.Clear();
int Numbers (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);

    return result;
}

int[] InputA (int length)
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Numbers("Введите элемент");
    }
    return array;
}

void PrintA (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int Count (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = Numbers ("Введите количество элементов  ");
int[] array;
array = InputA (length);
PrintA(array);
Console.WriteLine($"Количество чисел больше 0 --> {Count(array)}");