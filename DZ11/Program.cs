// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] numbers = new int[10];

void FillArray(int[] array, int min, int max){
for (int i = 0; i<array.Length; i++ ){
array[i] = new Random().Next(min, max);
}
}

void Print(int[] input)
{
for (int i = 0; i < input.Length; i++)
{
Console.Write(input[i]);

if (i != input.Length - 1)
Console.Write(", ");
}
Console.WriteLine();
}

int QuantityPositive(int[] array){
int quantity = 0;
for (int i = 0; i<array.Length; i++ ){
if (array[i] % 2 == 0)
{
quantity++;
}
}
return quantity;
}

FillArray(numbers, 100, 999);
Print(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");