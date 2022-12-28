namespace N
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random myRandom = new System.Random();
            System.Console.Write("a = ");
            int a = System.Convert.ToInt32(System.Console.ReadLine());
            int i = -1, j = -1;
            int m = 3, n = 4;
            int[,] array = new int[m, n];

            for(int k = 0; k < m; k++)
            {
                for(int l = 0; l < n; l++)
                {
                    array[k, l] = k + l;
                }
            }

            for (int k = 0; k < m; k++)
            {
                for (int l = 0; l < n; l++)
                {
                    System.Console.Write("{0} ", array[k,l]);
                }
                System.Console.Write("\n");
            }

            for (int k = 0; k < m; k++)
            {
                for (int l = 0; l < n; l++)
                {
                    if(array[k, l] == a)
                    {
                        i = k;
                        j = l;
                    }
                }
                System.Console.Write("\n");
            }
            if (i != -1) System.Console.WriteLine("[{0}, {1}]", i, j);
            else System.Console.WriteLine("такого числа в массиве нет");
            System.Console.ReadKey();
        }
    }
}
