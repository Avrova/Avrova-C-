
namespace N
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.Write("num = ");
            int num = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(IsPalindrome(num));
            System.Console.ReadKey(true);
        }

        static bool IsPalindrome(int num)
        {
            if(num > 99999 || num < 10000)
            {
                System.Console.WriteLine("Число не пятизначное");
                return false;
            }
            if (num >= 0 && num < 10)
                return true;
            int[] digits = new int[5];
            for (int i = 0; i < 5; i++)
            {
                digits[i] = num % 10;
                num /= 10;
            }
            for (int i = 0; i < 2; i++)
            {
                if (digits[i] != digits[4 - i])
                {
                    System.Console.WriteLine("Число не палиндром");
                    return false;
                }
            }
            System.Console.WriteLine("Число палиндром");
            return true;
        }
    }
}
