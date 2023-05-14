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

void printStringArray(string[] arr)
// Функция выводит массив. Пустые значения не выводятся.
{
    Console.Write("[");
    int stopCommaIndex = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length > 0) stopCommaIndex = i;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length == 0) continue;
        else
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j]);
            }
            if (i < stopCommaIndex)
            {
                Console.Write(", ");
            }
        }
    }
    Console.Write("]");
}

string[] CutStringsInArray(string[] arr, int maxLength)
// Создает строковый массив со строками из исходного массива, длина которых
// в случайном диапазоне от 0 до максимальной заданной
// длина новой строки не может быть больше длины исходной строки
{
    if (maxLength < 0) maxLength = 0;
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
printStringArray(newArray);