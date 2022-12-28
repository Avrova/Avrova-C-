namespace N
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("N = ");
            int N = System.Convert.ToInt32(System.Console.ReadLine());

            Natural(N);
            System.Console.ReadKey();
            
            void Natural(int n)
            {
                if (n != 0)
                {
                    System.Console.Write("{0}, ", n);
                    n--;
                    Natural(n);
                }
            }
        }
    }
}
