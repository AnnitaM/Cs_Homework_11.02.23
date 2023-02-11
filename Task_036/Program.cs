// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Enter array size: ");
int size = int.Parse(Console.ReadLine());

int[] array = GetRandomArray(size);
int sum = 0;

Console.WriteLine($"[{String.Join(" ", array)}]");

int[] GetRandomArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-100,100);
    }
    return res;
}

int SumNumber(int sum)
{
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
        {
            sum = sum + array[i] ;
        }
    return sum;
}

Console.Write($"sum of elements in odd positions is {SumNumber(sum)}");





