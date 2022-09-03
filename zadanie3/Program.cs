double [] FillArray()
{
    Console.WriteLine("Размер массива равен: ");
    int N = Convert.ToInt32(Console.ReadLine());
    double[] Array = new double[N];

    for( int i = 0; i < Array.Length; i++)
    {
        Array[i] = Math.Round( new Random().Next(-10, 10) + new Random().NextDouble(), 2 );
        if( i < Array.Length-1 ) Console.Write($"{Array[i]};  ");
        else Console.Write($"{Array[i]}  ");
    }
    return  Array;
}
double [] mda = FillArray();
double difference(double[] Array)
{
    double min = Array[0];
    double max = Array[0];
    
    for( int i = 0; i < Array.Length; i++)
    {
        if( Array[i] > max) max = Array[i];
    }
    for( int i = 0; i < Array.Length; i++)
    {
        if( Array[i] < min) min = Array[i];
    }
    double def = max - min;
    return def;
}
double results =  difference(mda);
Console.WriteLine();
Console.WriteLine($" Разница между макс. и мин. элементов массива: {results}");