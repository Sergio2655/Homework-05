/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] myArray = new int[10];
Random rnd = new Random();
int sum = 0;
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rnd.Next(1, 100);
}
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
for (int i = 1; i < myArray.Length; i = i + 2)
{

    sum = sum + myArray[i];

}
Console.WriteLine();
Console.Write("\nsum of elements in odd position is " + sum); 