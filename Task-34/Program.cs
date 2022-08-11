/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] myArray = new int[5];
Random rnd = new Random();
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rnd.Next(101, 999);
}
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine("Amount of even numbers is " + count);