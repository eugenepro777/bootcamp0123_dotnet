// 
int n = 5;
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
// Console.WriteLine(array[3]); - сложность O(1), выполнено за
// 1 действие
// [4,5,3,1,2] вывод массива O(n)
// отсортируем массив [1,2,3,4,5] - O(n * log n) - сортируем слиянием
// ((5+1)/2) * 5 - О(1)
// n < n*log(n) + 1 -  сортировка + сумма 
// однако быстрее решить так и затратим O(n)
int summa = 0;
for (int i = 0; i < n; i++)
{
    summa += array[i];
}
Console.WriteLine(summa);
// O(n^2)
int m = Convert.ToInt32(Console.ReadLine());
/* for (int i = 1; i <= m; i++)
{
    for (int j = 1; j <= m; j++)
    {
        Console.Write(i * j);
        Console.Write("\t");
    }
    Console.WriteLine();
} */
// ускоряем выполнение до O(n^2 / 2)
int[,] matrix = new int[m, m];
for (int i = 0; i < m; i++)
{
    for (int j = i; j < m; j++)
    {
        matrix[i, j] = (i+1) * (j+1);
        matrix[j, i] = (i+1) * (j+1);
    }
    Console.WriteLine();
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(matrix[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}