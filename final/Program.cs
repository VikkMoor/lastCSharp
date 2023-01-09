void PrintArray(string[] arr1)
{
    int len = arr1.Length;
    int pos = 0;
    while (pos < len)
    {
        Console.Write($"{arr1[pos]} ");
        pos++;
    }
}

void Task(string[] arr2, string[] arr3)
{
    int len3 = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i].Length <= 3)
        {
            arr3[len3] = arr2[i];
            len3++;
        }
    }
}

Console.Write("Enter text elements separated by spaces: ");
string text = Console.ReadLine();
string[] array = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
string[] array1 = new string[array.Length];

PrintArray(array);
Console.WriteLine();
Task(array, array1);
PrintArray(array1);