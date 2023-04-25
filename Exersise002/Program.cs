int GetCount(int value)
{
    int result = 0;

    while (value > 0)
    {
        result += value % 10;
        value /= 10;
    }

    return result;
}

int number = 452;
Console.WriteLine($"Summ of numbers in value = {GetCount(number)}");