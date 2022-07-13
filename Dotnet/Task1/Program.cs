namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the text: ");

            var input = Console.ReadLine();
      

            var chekPalindrome = IsPalindrome(input);

            if (chekPalindrome)
            {
                Console.WriteLine("Input is Palindrome");
            }
            else
            {
                Console.WriteLine("Input isn't Palindrome");
            }

        }



        static bool IsPalindrome(string? text)
        {

            char[] letters = text.ToLower().ToCharArray();

            Array.Reverse(letters);
            
            string reversedString = new string(letters);

            bool isPalindrome = reversedString == text.ToLower();

            return isPalindrome;
        }

    }
}