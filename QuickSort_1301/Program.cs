// Быстрая сортировка
using static Sorting;

int size = 100;
var arr = size.CreateArray()
            .Print()
            .SortQuick(0, size - 1)
            .Print();
