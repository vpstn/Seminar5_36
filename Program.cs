// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество чисел в массиве");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Наш массив: ");
PrintArray(numbers);
int sum = 0;

for (int i= 0; i < numbers.Length; i+=2)
    sum = sum + numbers[i];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

    void FillArrayRandomNumbers(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
        {
            numbers[j] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int j = 0; j < numbers.Length; j++)
        {
            Console.Write(numbers[j] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}