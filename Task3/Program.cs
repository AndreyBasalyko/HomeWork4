double[,] a = new double[1, 8];
 
Random random = new Random();
for ( int i = 0; i < 1; i++)
{
    Console.Write("[");
    for (int j = 0; j < 8; j++)
    {   
     
        a[i, j] = random.Next(100);
        Console.Write( "{0,4}", a[i, j] );
    } 
    Console.Write("]");
}