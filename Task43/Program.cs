namespace N

{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("b1 = ");
            double b1 = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("k1 = ");
            double k1 = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("b2 = ");
            double b2 = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("k2 = ");
            double k2 = System.Convert.ToInt32(System.Console.ReadLine());

            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;

            System.Console.WriteLine("\n({0}; {1})", x, y);
            System.Console.ReadKey();
        }
    }
}
