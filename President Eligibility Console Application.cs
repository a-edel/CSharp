namespace EligibilityConsoleApp
{
    class ConsoleApplication
    {
        static void Main(string[] args)
        {
            Console.Write("Are you a natural born citizen of the United States? ");
            bool naturalBornCitizen = Console.ReadLine().ToLower().Equals("yes");
            Console.WriteLine();

            int currentYear = DateTime.Now.Year;
            Console.Write("What is your birth year? ");
            int birthYear = int.Parse(Console.ReadLine());  
            bool isAtLeast35 = currentYear - birthYear >= 35;
            Console.WriteLine();

            Console.Write("How many years have you resided in the United States? ");
            bool isResidentFor14Years = int.Parse(Console.ReadLine()) >= 14;
            Console.WriteLine();

            Console.Write("How many prior terms have you served? ");
            bool servedLessThanTwoTerms = int.Parse(Console.ReadLine()) < 2;
            Console.WriteLine();

            Console.Write("Have you rebelled against the United States? ");
            bool hasNotRebelled = Console.ReadLine().ToLower().Equals("no");
            Console.WriteLine();

            if (naturalBornCitizen && isAtLeast35 && isResidentFor14Years && servedLessThanTwoTerms && hasNotRebelled)
            {
                Console.WriteLine("\nYou are eligible to run for president.");
            }
            else
            {
                Console.WriteLine("\nYou are not eligible to run for president.");
            }
        }
    }
}
