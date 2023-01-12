// НОД (Алгоритм Евклида)
// НОД(14, 21) = 7
int n = 140;
int m = 175;
int count = n * m;
while (n != m)
{
    if (n > m)
    {
        n = n - m;
    }
    else
    {
        m = m - n;
    }
}
// НОК
Console.WriteLine(count / n);