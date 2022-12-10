// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int a = 1;
List<int> array = new List<int>();
while (a > -10)
{
    Console.Write($"Введите [{array.Count}] элемент: ");
    int.TryParse(Console.ReadLine()!, out a);
    if (a > -10)
        array.Add(a);
}

Print(array);

int count = 0;
for (int i = 0; i < array.Count; i++)
{
    if (array[i] < 0)
        count++;
}
Console.WriteLine(count);

void Print(List<int> array)
{
    for (int i = 0; i < array.Count; i++)
        Console.Write($"{array[i]}, ");
    Console.WriteLine();
}