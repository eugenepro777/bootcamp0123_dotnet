// сортировка выбором
// 1 2 3 4 5 1 2 3
// MIN -> MAX
// v
// 0 1 2 3 4 5 6 7
// 7 6 3 4 5 1 2 3
// выбираем мин элемент и сравниваем его с остальными
using static Sorting;
// using static System.Console - и тогда Console дальше по тексту можно не писать
using static Infrastructure;
// изначально было
// int[] array = CreateArray(10);
// Print(array);
// SortSelection(array);
// Print(array);
// после выстраивания структуры проекта
10.CreateArray(min: 10, max: 30)
    .Print("<>")
    .SortSelection()
    .Print("_");

// второй вариант вывода
// int[] ar = 10.CreateArray(min: 10, max: 30)
// ar.Print();
// ar.SortSelection();
// ar.Print();

// Console.WriteLine($"[{String.Join(", ", array)}]");
// Console.WriteLine($"[{String.Join(", ", array)}]");
