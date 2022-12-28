namespace N
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("M = ");
            int M = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("(N > M) N = ");
            int N = System.Convert.ToInt32(System.Console.ReadLine());

            int sum = 0;
            System.Console.Write("Сумма: {0}", Sum(N));
            System.Console.ReadKey();

            int Sum(int n)
            {
                if (n != M - 1)
                {
                    sum += n;
                    n--;
                    Sum(n);
                }
                return sum;
            }
        }
    }
}
