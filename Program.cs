/*  Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо 
равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не 
рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string[] CreateArray(int size)
{
    return new string[size];
}

void FillArray(string[] array)
{
     for  (int i = 0; i < array.Length; i++)
       {
        Console.WriteLine($"Enter element: {i + 1}");
        array[i] = (Console.ReadLine()!);
       }
}

string PrintArray(string[] array)
{
    string res = String.Empty;
    for  (int i = 0; i < array.Length; i++)
        res +=array[i] + " ";
        return res;
}

int Count(string[] array)
{
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Length of {0} is {1}", array[i], array[i].Length);
        if (array[i].Length <= 3)
        {
            a++;
        }
    }
    return a;
}

int size = InputNum("Enter array size: ");
string[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
Console.WriteLine(txt);
Console.WriteLine();
int secondSize = Count(myArray);
string[] secondArray = CreateArray(secondSize);
Console.WriteLine();
// FillArray(secondArray);
// string secondTxt = PrintArray(secondArray);
// Console.WriteLine(secondTxt);
//Console.WriteLine(txt);