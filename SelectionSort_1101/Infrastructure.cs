public static class Infrastructure
{
    /// <summary>
    /// Метод создания и заполнения нового массива
    /// </summary>
    /// <param name="size">Размер нового массива</param>
    /// <param name="min">Нижняя граница</param>
    /// <param name="max">Верхняя граница</param>
    /// <returns>Новый массив</returns>
    public static int[] CreateArray(this int size, int min = 0, int max = 10)
    {
        return Enumerable.Range(1, size)
                .Select(item => Random.Shared.Next(min, max))
                .ToArray();
    }
    /// <summary>
    /// Метод вывода массива в консоль
    /// </summary>
    /// <param name="array">Исходный массив</param>
    /// <param name="separator">Символ-разделитель элементов</param>
    /// <returns>Исходный массив</returns>
    public static int[] Print(this int[] array, string separator = ",")
    {
        string output = String.Join(separator, array);
        Console.WriteLine($"[{output}]");
        return array;
    }
}
