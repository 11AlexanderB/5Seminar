int[] FillArray()
{
    Console.WriteLine("Количество элементов массива: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int [] Array = new int[N];

    for( int i = 0; i<Array.Length; i++ )
    {
        Array[i] = new Random().Next (-10, 10);
        if(i < Array.Length-1) Console.Write($" {Array[i]}, ");
        else Console.Write($" {Array[i]}  ");
    }
    return Array;
}
int[] mda = FillArray();
int SumOdd(int [] Array)
{
    int Sum = 0;
    
    for( int i = 1; i < Array.Length; i= i+2) Sum = Sum+Array[i];
    return Sum;
}
int results = SumOdd(mda);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равно: {results}");