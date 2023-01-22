/* 38: Задайте массив вещественных чисел. Найдите
 разницу между максимальным и минимальным элементов массива. */

Console.Clear();
int[] CreateRandomArray(int N, int start, int end)
 {
 int[] RandomArray = new int[N];
 for (int i = 0; i < N; i++)
 {
 RandomArray[i] = new Random().Next(start, end + 1);
 }
 return RandomArray;
 }
void ShowArray(int[] array)
{
 for (int i = 0; i < array.Length; i++)
 {
 Console.Write(array[i] + " ");
 }
 Console.WriteLine();
 }
int[] mass = CreateRandomArray(10, 0, 10);
ShowArray(mass);
int diffmaxmin(int[] array)
{
    int max = array[0];
    int min = array[0];
    foreach(int num in array)
    {
        if (num > max) max = num;
        if (num < min) min = num;
    }
return max - min;
}
Console.WriteLine(diffmaxmin(mass));
