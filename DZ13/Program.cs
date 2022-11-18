// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] arrayRealNumbers = new double[size];
Console.WriteLine("массив: ");

for (int i = 0; i < arrayRealNumbers.Length; i++ )
{
arrayRealNumbers[i] = new Random().Next(1, 99);
Console.Write(arrayRealNumbers[i] + " ");
}

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

for (int i = 1; i < arrayRealNumbers.Length; i++)
{
if (maxNumber < arrayRealNumbers[i])
{
maxNumber = arrayRealNumbers[i];
}
if (minNumber > arrayRealNumbers[i])
{
minNumber = arrayRealNumbers[i];
}
}

double decision = maxNumber - minNumber;

Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами равна: {decision}"); 
