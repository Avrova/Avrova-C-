namespace N
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("M = ");
            int M = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("N = ");
            int N = System.Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("A({0}, {1}) = {2}", M, N, A(M, N));
            System.Console.ReadKey();

            int A(int m, int n)
            {
                if (m == 0) return n + 1;
                if (m != 0 && n == 0) return A(m - 1, 1);
                if (m > 0 && m > 0) return A(m - 1, A(m, n - 1));
                return A(m, n);
            }
        }
    }
}
