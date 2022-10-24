// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Введите количество чисел: ");
int Count = int.Parse(Console.ReadLine()!);

int[] Array = new int[Count];

for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"Введите число {i+1}: ");
    Array[i] = int.Parse(Console.ReadLine()!);
}
int count = 0;
foreach (var item in Array)
{
if (item > 0)
count++;
}

Console.Write($"\nКоличество чисел больше нуля: {count} ");

Console.ReadLine();
