// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Write("Enter the size of array: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] source_array = new string[n];

int new_array_size = 0;

Console.WriteLine("Enter your array:");

string[] FillArray(string[] array)
{
    for (int i = 0; i < array.Length; ++i)
    {
        array[i] = Console.ReadLine();
        if (array[i].Length == 0)
        {
            bool no_validate = true;
            while (no_validate)
            {
                Console.WriteLine("String value can't be empty. Try again:");
                array[i] = Console.ReadLine();
                if (array[i].Length > 0)
                {
                    no_validate = false;
                }
            }
        }
        if (array[i].Length <= 3)
        {
            ++new_array_size;
        }
    }
    return array;
}

FillArray(source_array);

string[] new_array = new string[new_array_size];

string[] GetNewArray(string[] array)
{
    int j = 0;
    for (int i = 0; i < source_array.Length; ++i)
    {
        if (source_array[i].Length <= 3)
        {
            array[j] = source_array[i];
            ++j;
        }
    }
    return array;
}

GetNewArray(new_array);

string[] PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; ++i)
    {
        Console.Write(array[i] + " ");
    }
    return array;
}

Console.Write("New array is: ");
PrintArray(new_array);