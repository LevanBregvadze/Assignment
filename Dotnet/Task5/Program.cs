namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number of staits: ");
            int numberOfStares = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine($"Total Variants: {CountVariants(numberOfStares)}");


        }



        static int FibonaciNumber(int n)
        {
            if (n <= 1)
                return n;
            return FibonaciNumber(n - 1) + FibonaciNumber(n - 2);
        }

        
        static int CountVariants(int stairCount)
        {
            return FibonaciNumber(stairCount + 1);
        }
    }
}