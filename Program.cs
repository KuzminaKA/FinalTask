// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = new string [4] {"Hello", "2", "world", ":-)"};


string [] CreateNewArray (string[] array, int Length)
{
    string[] newArray = new string[Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        newArray[count] = array[i];
        count++;
        }
    }
    return newArray;
}

void Printarray(string [] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write(array[i] + "; ");
    }
    System.Console.Write(array[array.Length-1] + " ]");
}

Printarray(array);
System.Console.WriteLine();
string [] newArray = CreateNewArray(array, 2);
Printarray(newArray);