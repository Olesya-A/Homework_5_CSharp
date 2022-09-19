// 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите количество элементов массива ");
int size = int.Parse(Console.ReadLine()!);
int[] array = CreateRandomArray(size);
PrintArray(array);
int sum = SumOfElements(array);
Console.Write($"Сумма элементов, стоящих на нечётных позициях = {sum}");


int[] CreateRandomArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(-20, 21);
    }
    return numbers;
}

void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine();
}

int SumOfElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
        sum += array[i];
    return sum;
}

