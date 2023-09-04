// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Write("Enter the size of array: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] source_array = new string[n];

int new_array_size = 0;

for (int i = 0; i < source_array.Length; ++i)
{
    source_array[i] = Console.ReadLine();
    if (source_array[i].Length <= 3)
    {
        ++new_array_size;
    }
}

string[] new_array = new string[new_array_size - 1];

for (int i = 0; i < source_array.Length; ++i)
{
    int j = 0;
    if (source_array[i].Length <= 3)
    {
        new_array[j] = source_array[i];
        Console.Write(new_array[j] + " ");
        ++j;
    }
}