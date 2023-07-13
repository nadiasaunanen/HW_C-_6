// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Number(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int result = Convert.ToInt32(number);
    return result;
}

int[] InputArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Number($"Введите {i + 1} элемента: ");
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");   // "  " Будет меньше расстояние
    }
    Console.Write("]");
}

int GetPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
int length = Number("Введите количество элементов: ");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел в массиве > 0:  {GetPositiveNumbers(array)}");





// Console.Write("Введите числа через запятую: ");
// int[] numbers = StringToNum(Console.ReadLine());
