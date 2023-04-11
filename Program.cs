// Задача: Написать программу, которая
// из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void printStringArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == string.Empty)
        {

        }
        else
        {
        Console.Write(arr[i]);
        Console.Write(", ");
        }
       
    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}

string[] array = new string[5] {"Elephant", "Koala", "", "E", "Jaguar"};

printStringArray(array);
Console.Write(" -> ");
printStringArray(array);