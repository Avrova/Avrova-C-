namespace N
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Random myRandom = new System.Random();
            int[] array = new int[8];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(0, 8);
                System.Console.Write("{0} ", array[i]);
            }
            System.Console.ReadKey(true);
        }
    }
}
