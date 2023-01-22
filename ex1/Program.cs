//Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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
int[] mass = CreateRandomArray(10, 100, 1000);
ShowArray(mass);
even(mass);

int even(int[] array)
{
    int i = 0;
    foreach(int num in array)
    if (num % 2 == 0)
    {
        i++;
    }
return i;
}
Console.WriteLine(even(mass));
