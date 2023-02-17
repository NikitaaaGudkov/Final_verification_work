/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/

// Вывод массива на консоль
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; ++i)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

// Создание массива из строк, длина которых меньше или равна 3 символа
string[] SelectSubArray(string[] userArray)
{
    int lengthNewArray = 0;
    for (int i = 0; i < userArray.Length; ++i)
    {
        if (userArray[i].Length <= 3)
        {
            ++lengthNewArray;    
        }
    }
    string[] result = new string[lengthNewArray];
    int j = 0;
    for (int i = 0; i < userArray.Length; ++i)
    {
        if (userArray[i].Length <= 3)
        {
            result[j] = userArray[i];
            ++j;
        }
    }
    return result;
}


string[] example1 = new string[] {"hello", "2", "world", ":-)"};
System.Console.WriteLine("Пример массива: ");
PrintArray(example1);
string[] subArray1 = SelectSubArray(example1);
System.Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа: ");
PrintArray(subArray1);

string[] example2 = new string[] {"1234", "1567", "-2", "computer science"};
System.Console.WriteLine("Пример массива: ");
PrintArray(example2);
string[] subArray2 = SelectSubArray(example2);
System.Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа: ");
PrintArray(subArray2);

string[] example3 = new string[] {"Russia", "Denmark", "Kazan"};
System.Console.WriteLine("Пример массива: ");
PrintArray(example3);
string[] subArray3 = SelectSubArray(example3);
System.Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа: ");
PrintArray(subArray3);
