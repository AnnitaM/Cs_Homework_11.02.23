// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Clear();
Console.Write("Enter array size: ");
int size = int.Parse(Console.ReadLine());

int[] array = GetRandomArray(size);
int count = 0;

Console.WriteLine($"[{String.Join(" ", array)}]");

int[] GetRandomArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 999);
    }
    return res;
}

int evenNumCount(int count)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}

Console.WriteLine($"The number of even numbers is {evenNumCount(count)}");
/*evenNumCount(count);
*/

