using System;

class NBATest
{
    static void Main()
    {
        while (true)
        {
            int summa = 0;

            Console.WriteLine("Hi, welcome to the NBA test");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}!");

            Console.WriteLine("Let's start the game!");
            Console.WriteLine("First question: Who won the NBA championship in 2022?");
            Console.WriteLine("1. Warriors\n2. Boston");

            Console.WriteLine("Enter your answer (1/2):");

            try
            {
                string answer1Input = Console.ReadLine();

                if (int.TryParse(answer1Input, out int answer1))
                {
                    if (answer1 == 1)
                    {
                        summa++;
                        Console.WriteLine("Correct answer!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong answer!");
                    }

                    Console.WriteLine("Next question: Who won the Finals MVP in 2018? Curry or LeBron?");
                    Console.WriteLine("1. Curry\n2. LeBron");
                    string answer2Input = Console.ReadLine();

                    if (int.TryParse(answer2Input, out int answer2))
                    {
                        if (answer2 == 2)
                        {
                            summa++;
                            Console.WriteLine("Correct answer!");
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer!");
                        }

                        Console.WriteLine("Last question: Which team drafted LeBron James?");
                        Console.WriteLine("1. Cleveland\n2. Miami");
                        string answer3Input = Console.ReadLine();

                        if (int.TryParse(answer3Input, out int answer3))
                        {
                            if (answer3 == 1)
                            {
                                summa++;
                                Console.WriteLine("Correct answer!");
                            }
                            else
                            {
                                Console.WriteLine("Wrong answer!");
                            }

                            Console.WriteLine($"You scored {summa} out of 3.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.WriteLine("Do you want to play again? (Y/N)");
            string playAgain = Console.ReadLine();

            if (playAgain.ToUpper() != "Y")
            {
                break;
            }
        }

        Console.WriteLine("Thank you for playing the game!");
    }
}
