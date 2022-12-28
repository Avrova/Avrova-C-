namespace N
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите число M");
            int M = System.Convert.ToInt32(System.Console.ReadLine());
            int pr = 0;
            for (int i = 0; i < M; i++)
            {
                System.Console.WriteLine("Введите число: ");
                int a = System.Convert.ToInt32(System.Console.ReadLine());
                if (a > 0) pr++;
            }
            System.Console.WriteLine("\nПоложительных: {0}", pr);
            System.Console.ReadKey();
        }
    }
}
