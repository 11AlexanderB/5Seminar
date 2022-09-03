int [] FillArray()
{
    Console.WriteLine("Размер массива равен: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int [] Array = new int[N];
    
    for( int i = 0; i<Array.Length; i++ )
    {
        Array[i] = new Random().Next (99, 1000);
        if(i < Array.Length-1) Console.Write($" {Array[i]}, ");
        else Console.Write($" {Array[i]}  ");
    }
    return Array;
}
int[] dre = FillArray();

int CountEven(int[] Array)
{
    int count = 0;

    for( int i = 0; i<Array.Length; i++ )
    {
        if(Array[i]%2 == 0) count++;
    }
    return count;
}
int results = CountEven(dre);
Console.WriteLine();
Console.WriteLine($"Количество четных элементов массива равно: {results}");
