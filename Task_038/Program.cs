// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Enter array size: ");
int size = int.Parse(Console.ReadLine());
double[] array = GetRandomArray(size);

Console.WriteLine($"[{String.Join(" ", array)}]");
Console.Write($"Difference between maximum and minimum is {DifMaxMin()}");

double[] GetRandomArray(int size)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next();
    }
    return res;
}


double DifMaxMin()
{
    double min = array[0];
    double max = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
        Console.WriteLine($"current cicle: {i} min {min}; max {max}");
    }
    return  max - min;;
    
}


