// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;

    }
    return arr;
}
void PrintArrayDouble(double[] arr, int round = 1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double num = Math.Round(arr[i], round);
        if (i < arr.Length - 1) Console.Write($"{num}, ");
        else Console.Write($"{num}");
    }

    Console.WriteLine("]");


}
double MaxElemInArray(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;

}

double MinElemInArray(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;

}

double DifferencesMinMaxElem(double min, double max)
{
  
     double diff = max - min;
     diff =  Math.Round(diff, 1);

    return diff;
}




double[] array = CreateArrayRndDouble(9, 10, 99);
PrintArrayDouble(array);
double max = MaxElemInArray(array);
double min = MinElemInArray(array);
double diffMinMaxElem = DifferencesMinMaxElem(min, max);
Console.WriteLine($"Разница между максимальным и минимальным элементоми массива = {diffMinMaxElem}");