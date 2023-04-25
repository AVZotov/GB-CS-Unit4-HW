int[] FillArray(int[] userArray)
{
    for (int i = 0; i < userArray.Length; i++)
    {
        Console.Write($"Enter {i + 1} value to add into the array: ");
        userArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    return userArray;
}

Console.Clear();
int[] userArray = new int[8];
FillArray(userArray);
Console.WriteLine(String.Join(", ", userArray));