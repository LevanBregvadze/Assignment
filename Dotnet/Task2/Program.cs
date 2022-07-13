namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter money to be splitted: ");
            int input = Convert.ToInt32(Console.ReadLine());

            var minNumberOfCoins = MinSplit(input);

            Console.WriteLine($"Minimum number of coins: {minNumberOfCoins}");
        }




        static int MinSplit(int amount)
        {

            int[] coinSizes = { 1, 5, 10, 20, 50 };
            int numberOfCoins = 0;

            for (int i = coinSizes.Length - 1; i >= 0; i--)
            {
                numberOfCoins += amount / coinSizes[i];
                amount %= coinSizes[i];

            }

            return numberOfCoins;

        }
    }
}