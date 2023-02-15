// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

System.Console.WriteLine();
Console.Write("Массив:");
System.Console.WriteLine();
int[] array = GetArray(8,100,1000); // размер, мин и макс значения
int i = 0;
int[]GetArray (int size, int minValue, int maxValue)
{
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
    {
      res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

void sum(int[]arr)
{
  int count=0;
  for (i=0; i < arr.Length; i++)
    if (arr[i]%2==0)
       {
        count++;
       }
    Console.WriteLine($"Количество четных чисел в массиве равно : {count}");
}
Console.WriteLine(String.Join(" ", array));
sum(array);
