// 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите количество элементов массива ");
int size = int.Parse(Console.ReadLine()!);
float[] array = CreateRandomArray(size);
PrintArray(array);
Console.WriteLine($"Наибольший элемент массива = {FindMax(array)}");
Console.WriteLine($"Наименьший элемент массива = {FindMin(array)}");
float diff = FindDiff(FindMax(array), FindMin(array));
Console.WriteLine($"Разницу между максимальным и минимальным элементов массива = {diff}");

float[] CreateRandomArray(int size)
{
    float[] numbers = new float[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(0, 100);
    }
    return numbers;
}

void PrintArray(float[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine();
}

float FindMax(float[] array)
{
    float max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

float FindMin(float[] array)
{
    float min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

float FindDiff(float max, float min)
{
    float diff = max - min;
    return diff;
}