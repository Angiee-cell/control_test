// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] array = new string[7] { "6832", "hello", "142", ":;", "hi", "world!", "238*" };
string[] array1 = new string[array.Length];

NewArray(array, array1);
PrintArray(array1);


void NewArray(string[] array, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array1[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i] + " "}");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Исходный массив:");
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"{array[i]} ");
}
System.Console.WriteLine();


System.Console.WriteLine("Новый массив:");
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"{array1[i]} ");
}
System.Console.WriteLine();
