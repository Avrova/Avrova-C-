namespace N

{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random myRandom = new System.Random();
            System.Console.WriteLine("m = 3");
            System.Console.WriteLine("n = 4");
            int m = 3, n = 4;
            double[,] array = new double[m, n];

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    array[i, j] = myRandom.Next()/ 1392938;
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    System.Console.Write("{0,5:f1} ", array[i,j]);
                }
                System.Console.Write("\n");
            }
            System.Console.ReadKey();
        }
    }
}
