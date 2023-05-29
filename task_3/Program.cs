string CreateArray(int[] array)
{
    string result = String.Empty;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($"{array[i]} ");
    }
    return result;
}




Console.WriteLine("This programme is designed for generating an array that is consisted of 8 elements.");
int[] mainarray = new int[8];
Console.WriteLine();
Console.Write("This is a generated array: ");
Console.WriteLine(CreateArray(mainarray));