// Пузырьковая сортировка

/* [3, 1, 5, 0, 7, 9, 8] - изначально
[3, 1] - работаем парами, меньший элемент как бы "всплывает"
-> [1, 3, 5, 0, 7, 9, 8] - 1й шаг
->[1, 3, 0, 5, 7, 9, 8]- 2й шаг
->[1, 0, 3, 5, 7, 9, 8]- 3й шаг
->[0, 1, 3, 5, 7, 9, 8]- 4й шаг
->[0, 1, 3, 5, 7, 8, 9]- 5й шаг
->[0, 1, 3, 5, 7, 8, 9] - проходим столько раз сколько элементов в массиве*/

Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите элементы массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();
// по i количество проходов, j по элементам
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine($"итерация {i} Отсортированный массив: [{string.Join(",", array)}]");
}