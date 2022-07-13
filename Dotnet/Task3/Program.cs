namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter array lenght: ");
            var arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrayLength];

            Console.WriteLine("Please fill the array: ");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Number{i+1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            var minInteger = NotContains(array);
            Console.WriteLine($"Lowest Integer is: {minInteger} ");

        }


        static int NotContains(int[] array)
        {

            var sortedArray = array.OrderBy(x => x).ToArray();

            var count = 1;

            while (true)
            {
                bool isk = count == sortedArray[count - 1];
                count++;


                if (!isk)
                    return  count - 1;

                if (count > sortedArray.Length)
                    return count;  

            }

        }
    }
}