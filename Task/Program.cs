// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Write("Enter the size of array: ");
int n = Convert.ToInt32(Console.ReadLine()); // Запрашиваем размер массива от пользователя.

string[] source_array = new string[n]; // Создаем исходный массив строк.

int new_array_size = 0; // Определяем размер будущего массива по умолчанию.

string[] FillArray(string[] array) // Реализация метода заполнения исходного массива.
{
    for (int i = 0; i < array.Length; ++i)
    {
        array[i] = Console.ReadLine(); // Запрашиваем ввод строк от пользователя.

        if (array[i].Length == 0) // Проверка на пустую строку.
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

        if (array[i].Length <= 3) // Если новое значение больше 3-х символов, то увеличиваем размер будущего массива на 1.
        {
            ++new_array_size;
        }
    }

    return array;
}

Console.WriteLine("Enter your array:");
FillArray(source_array); // Вызов метода заполнения исходного массива.

string[] new_array = new string[new_array_size]; // Создаем новый массив.

string[] GetNewArray(string[] array) // Реализация метода заполнения нового массива.
{
    int j = 0;

    for (int i = 0; i < source_array.Length; ++i)
    {
        if (source_array[i].Length <= 3) // Если элемент не больше 3-х символов, то определяем его в новый массив.
        {
            array[j] = source_array[i];
            ++j;
        }
    }

    return array;
}

GetNewArray(new_array); // Вызов метода заполнения нового массива.

string[] PrintArray(string[] array) // Реализация метода вывода массива.
{
    for (int i = 0; i < array.Length; ++i)
    {
        Console.Write(array[i] + " ");
    }

    return array;
}

Console.Write("New array is: ");
PrintArray(new_array); // Вызов метода вывода массива.