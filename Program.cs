using Mission2;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        
        //Prompt and collect input from user
        Console.WriteLine("How many dice rolls would you like to simulate?");
        string input = Console.ReadLine();
        int numrolls = int.Parse(input);

        //Print results
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1 % of the total number of rolls");
        Console.WriteLine("Total number of rolls = " + numrolls);
        
        //Use method in RollDice class to print results
        RollDice rd = new RollDice();
        int[] rollResults = rd.Rolls(numrolls);
        
        for (int i = 2; i <= 12; i++)
        {
            int percentage = rollResults[i - 2] * 100 / numrolls;
            Console.WriteLine($"{i}: {new string('*', percentage)}");
        }

        Console.WriteLine("Thank you for using the dice throwing simulator!");
    }
}