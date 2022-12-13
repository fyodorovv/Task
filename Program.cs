Main();

void Main()
{
    string[] ar = EnterStringArray();
    Console.WriteLine();
    PrintArray(ar);
    Console.WriteLine();
    string[] lessThree = GetStringLessThreeArray(ar);
    PrintArray(lessThree);
}

string[] GetStringLessThreeArray(string[] array)
{
    string[] result = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = array[i];
        }
    }
    return result;
}

string[] EnterStringArray()
{
    string[] array = new string[0];
    Console.WriteLine("Введите строку: ");
    string s = Console.ReadLine();
    while (s != "end")
    {
        Array.Resize(ref array, array.Length + 1);
        array[array.Length - 1] = s;
        Console.WriteLine("Введите строку (чтобы прервать, введите end) : ");
        s = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}