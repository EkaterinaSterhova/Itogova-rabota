// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



void MethodCreateInputArray(string[] InputArray)
{
    Console.Write($"Input array: ");
    for (int i = 0; i < InputArray.Length; i++) Console.Write($"{InputArray[i]} ");
    Console.WriteLine();
}

void MethodCreateOutputArray(string[] OutputArray)
{
    Console.Write($"Output array: ");
    string[] newarr = new string[OutputArray.Length];
    for (int i = 0; i < OutputArray.Length; i++)
    {
        if (OutputArray[i].Length <= 3)
        {
            newarr[i] = OutputArray[i];
            Console.Write($"{newarr[i]} ");
        }
    }
    Console.WriteLine();
}

string[] array = { "hello_world", "Dol","2", "Gaubica","Pushca","1234", "1567", "-2","computer science", ":-)" , "123", "^_^", "wiz"};

Console.Clear();
Console.WriteLine();
MethodCreateInputArray(array);
Console.WriteLine();
MethodCreateOutputArray(array);
Console.WriteLine();