Console.WriteLine("Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна m символа");

var n = ReadNumberConsole("Введите кол-во строк: ");
var text = new string[n];
FillText(text);

var m = ReadNumberConsole("Введите m: ");

var result = GetStringLimited(text, m);
Console.WriteLine("Результат: ");
DisplayArr(result);

static int ReadNumberConsole(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "");
}

static void FillText(string[] text)
{
    for (int i = 0; i < text.Length; i++)
    {
        text[i] = Console.ReadLine() ?? "";
    }
}

static string[] GetStringLimited(string[] text, int limit = 3)
{
    var result = new List<string>();

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3)
            result.Add(text[i]);
    }

    return result.ToArray();
}

static void DisplayArr<T>(T[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i] + " ");
    }
    Console.WriteLine();
}