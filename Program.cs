// Задача: Написать программу, которая
// из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


void printStringArray(string[] arr, bool skipEmpty = false)
// Функция выводить массив. Если skipEmpty = true - то пустые значения не выводятся
{
    bool[] commaArr = new bool[arr.Length];
    if (skipEmpty)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] != string.Empty) commaArr[i] = true;
        }
        int skipCommaIndex = arr.Length - 1;
        for (int j = arr.Length - 1; j >= 0; j--)
        {
            if (arr[j] != string.Empty) skipCommaIndex = j;
            j = -1;
        }
        commaArr[skipCommaIndex] = false;
    }
    Console.Write("[");
    for (int k = 0; k < arr.Length; k++)
    {
        Console.Write(arr[k]);
        if (skipEmpty && commaArr[k]) Console.Write(", ");
        else if (!skipEmpty && k != arr.Length - 1) Console.Write(", ");
    }

    Console.Write("]");
}

string[] CutStringsInArray(string[] arr, int maxLength)
{
    if (maxLength  < 0) maxLength  = 0;
    string[] newArr = new string[arr.Length];
    int stringLength = 0;
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length == 0)
        {
            stringLength = 0;
        }
        else if (arr[i].Length >= maxLength)
        {
            stringLength = rnd.Next(0, maxLength + 1);
        }
        else
        {
            stringLength = rnd.Next(0, arr[i].Length + 1);
        }

        newArr[i] = string.Empty;
        for (int k = 0; k < stringLength; k++)
        {
            newArr[i] += arr[i][k];
        }
    }
    return newArr;
}

string[] array = new string[5] { "Elephant", "Koala", "", "E", "Jaguar" };
int maxStringLength = 3;
string[] newArray = CutStringsInArray(array, maxStringLength);

printStringArray(array);
Console.Write(" -> ");
printStringArray(newArray, skipEmpty: true);


string[] array1 = new string[5] { "A1", "A2", "", "A4", "" };
string[] array2 = new string[5] { "A1", "A2", "", "", "A5" };
string[] array3 = new string[5] { "A1", "", "", "", "A5" };
string[] array4 = new string[5] { "A1", "", "", "", "" };
string[] array5 = new string[5] { "", "", "A3", "", "" };
Console.WriteLine();
printStringArray(array1, skipEmpty: true);
Console.WriteLine();
printStringArray(array2, skipEmpty: true);
Console.WriteLine();
printStringArray(array3, skipEmpty: true);
Console.WriteLine();
printStringArray(array4, skipEmpty: true);
Console.WriteLine();
printStringArray(array5, skipEmpty: true);