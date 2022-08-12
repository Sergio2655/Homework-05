/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] myArray = new double[5];
Random rnd = new Random();
double min = myArray[0];
double max = myArray[0];
double difference = 0;
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = 5 - rnd.Next(11) + rnd.NextDouble();
}
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(Math.Round(myArray[i], 2) + " ");
}
for (int i = 1; i < myArray.Length; i++)
{
    if (myArray[i] < min)
    {
        min = myArray[i];
    }
    else if (myArray[i] > max)
    {
        max = myArray[i];
    }
}

difference = max - min;

Console.WriteLine();
Console.WriteLine("\nMinimal element is " + Math.Round(min, 2));
Console.WriteLine("Maximum element is " + Math.Round(max, 2));
Console.WriteLine("\nDifference between maximum and minimal elements is " + Math.Round(difference, 2));

