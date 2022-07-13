namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter brackets sequence to be checked: ");
            var brackets = Console.ReadLine();
       
            bool valid;

            valid = brackets.All(x => char.IsLetter(x) || x == '(' || x == ')');


            if (valid)
            {
                var isProperly = IsProperly(brackets);
                if (isProperly)
                {
                    Console.WriteLine("Correct sequence");
                }
                else
                {
                    Console.WriteLine("Inccorect Sequence");
                }
            }
            else
            {
                Console.WriteLine("Not Valid Inputs");
            }

          
            
            

        }


        static bool IsProperly(string sequence)
        {
            var openBrackets = sequence.Count(x => x.Equals('('));
            var closeBrackets = sequence.Count(x => x.Equals(')'));

            bool isTrue = openBrackets == closeBrackets;
            return isTrue;
        }
    }
}