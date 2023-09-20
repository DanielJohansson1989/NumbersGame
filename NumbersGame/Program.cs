// Daniel Johansson SUT23

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            

            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

                Random random = new Random();
                int number = random.Next(1, 21);

                int tries = 0;
                bool isCorrect = false;

                while (tries < 5 && isCorrect == false)
                {
                    // The user input is evaluated in the metod CheckGuess which then returns either false or true.
                    int guess = Convert.ToInt32(Console.ReadLine());
                    isCorrect = CheckGuess(number, guess);
                    tries++;
                }

                if (isCorrect)
                {
                    Console.WriteLine("Woho! Du gjorde det!");
                }

                else
                {
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                }

                bool hasAnswered = false; // A boolean to make sure that the user cannot continue unless he types in j or n. 

                while (!hasAnswered)
                {
                    Console.WriteLine("Vill du spela igen? (Tryck j för ja eller n för nej)");
                    string answer = Console.ReadLine();

                
                    if (answer == "j" || answer == "J")
                    {
                        hasAnswered = true;
                    }// isRunning is true, program continues

                    else if (answer == "n" || answer == "N")
                    {
                        isRunning = false;
                        hasAnswered = true;
                    }
                        
                    else 
                    {
                        Console.WriteLine("Du tryckte varken på j eller n."); 
                        // hasAnswered is false, loop contiues.
                    }
                }
            }
            Console.WriteLine("Programmet avslutas");
        }
            /*
            * Method that compares a guessed number with the answer 
            * and prints a message in the console depending on whether
            * the guess is too high, too low or correct.
            * It also returns the boolean value false, unless the guess
            * is equal to the answer in which case it returns true.
            */
        static bool CheckGuess(int answer, int guess)
        {
            if (guess > answer)
            {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                    return false;
            }

            else if (guess < answer)
            {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                    return false;
            }

            else
            {
                    return true;
            }
        }
        
    }   
}