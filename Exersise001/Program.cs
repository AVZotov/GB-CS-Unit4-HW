int GetDegree(int value, int degree)
{
    int result = 1;

    for (int i = 1; i <= degree; i++)
    {
        result *= value;
    }

    return result;
}

Console.Clear();
Console.Write("Enter a value: ");
int value = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter degree: ");
int degree = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{value}^{degree} degree = {GetDegree(value, degree)}");