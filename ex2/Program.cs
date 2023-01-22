/*36: Задайте одномерн ый массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. */

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

int summeven(int[] array)
{
    //int k = 0;
    int count = 0;
    for(int k = 1; k < array.Length; k = k + 2)
    {
        count = count + array[k];
    }
    return count;
}
Console.WriteLine(summeven(mass)); 
