using System.Runtime.CompilerServices;
/// File: Project01.cs
/// Name(s): Matthew Childress & Christopher Brown
/// Class: CISP1010
/// Semester: Fall 2022
/// Project: Mega Rasslin' Maniacs - Rock Bottom, Flying Leg Scissors & Paper Tiger
namespace Project01
{
    /// <summary>
    /// This class is a simple Rock Paper Scissors game that uses multiple methods to show type conversions,
    /// selection statements, and loops.
    /// </summary>
    internal class Project01
    {
        /// <summary>
        /// this method is the main entry point into the game. It uses a do/while loop to execute menu choices unless 4 is picked.
        /// </summary>
        /// <param name="args">player inputs</param>
        static void Main(string[] args)
        {
            char menuChoice;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            do
            {
                PrintLargeWelcomeMessage();
                menuChoice = ShowMenu();
                if (menuChoice == '1')
                {
                    OnePlayerMode();
                }
                else if (menuChoice == '2')
                {
                    TwoPlayerMode();
                }
                else if (menuChoice == '3')
                {
                    RulesMode();
                }
                else if (menuChoice == '4')
                {
                    ExitOption();
                }

            } while (menuChoice != '4');
        }
        // Utility Methods
        /// <summary>
        /// A method that given a message prompt will, print the message, allow th euser to enter a value,
        /// and without pressing enter, return to the char value to the user.
        /// </summary>
        /// <param name="messagePrompt"></param>
        /// <returns>char value</returns>
        static char PromptForChar(string messagePrompt)
        {
            Console.Write(messagePrompt);
            return Convert.ToChar(Console.ReadLine());
        }
        /// <summary>
        /// A method that given a message prompt will, print th emessage, allow the user to enter a value,
        /// and without pressing enter, return the char value to the user. THe value entered by the user shall
        /// not be shown on the screen.
        /// </summary>
        /// <param name="messagePrompt"></param>
        /// <returns>char value that's hidden from console</returns>
        static char PromptForCharHidden(string messagePrompt)
        {
            Console.Write(messagePrompt);
            return Convert.ToChar(Console.ReadKey(true).KeyChar);
        }
        /// <summary>
        /// A method that given a message prompt will print the message, allow the user to enter a value, 
        /// and without pressing enter, return the char value to the user. The value entered by the user shall
        /// not be shown on the screen.
        /// </summary>
        /// <param name="messagePrompt">user input</param>
        /// <returns>input converted to a string</returns>
        static string PromptForString(string messagePrompt)
        {
            Console.Write(messagePrompt);
            return Convert.ToString(Console.ReadLine());
        }
        /// <summary>
        /// Preints a message to 'press any key to continue' and waits for the user to press enter
        /// </summary>
        static void PressAnyKey()
        {
            Console.WriteLine("---PRESS ANY KEY TO CONTINUE---");
            Console.ReadLine();

        }
        // game logic
        /// <summary>
        /// given two player choices [1,2,3], the method will return a byte value, 1 for player one
        /// 2 for playertwo, or a 0 for a tie
        /// </summary>
        /// <param name="playerOneChoice">player 1 input</param>
        /// <param name="playerTwoChoice">player 2 input</param>
        /// <returns>winner based on selection statement.</returns>
        static byte CalculateWinner(char playerOneChoice, char playerTwoChoice)
        {
            byte result;
            // 1 - rock 2 - paper 3 - scissors
            if ((playerOneChoice == '1' && playerTwoChoice == '3') || (playerOneChoice == '2' && playerTwoChoice == '1') || (playerOneChoice == '3' && playerTwoChoice == '2'))
            {
                result = 1;
            }
            else if ((playerOneChoice == '1' && playerTwoChoice == '2') || (playerOneChoice == '2' && playerTwoChoice == '3') || (playerOneChoice == '3' && playerTwoChoice == '1'))
            {
                result = 2;
            }
            else
            {
                result = 0;
            }
            return result;
        }
        /// <summary>
        /// Given two player names and their choices. This method will print the results of a match.
        /// </summary>
        /// <param name="playerOneName"></param>
        /// <param name="playerOneChoice"></param>
        /// <param name="playerTwoName"></param>
        /// <param name="playerTwoChoice"></param>
        static void PrintResults(string playerOneName, char playerOneChoice, string playerTwoName, char playerTwoChoice)
        {
            byte result;
            string p1Choice, p2Choice;

            result = CalculateWinner(playerOneChoice, playerTwoChoice);
            p1Choice = ConvertChoiceToName(playerOneChoice);
            p2Choice = ConvertChoiceToName(playerTwoChoice);

            if (result == 1)
            {
                Console.WriteLine();
                Console.WriteLine($"{playerOneName} chose {p1Choice}.");
                Console.WriteLine($"{playerTwoName} chose {p2Choice}.");
                Console.WriteLine();
                Console.WriteLine($"{playerOneName} wins!! What a brutal round!");
            }
            else if (result == 2)
            {
                Console.WriteLine();
                Console.WriteLine($"{playerOneName} chose {p1Choice}.");
                Console.WriteLine($"{playerTwoName} chose {p2Choice}.");
                Console.WriteLine();
                Console.WriteLine($"{playerTwoName} wins!! What a brutal round!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"{playerOneName} chose {p1Choice}.");
                Console.WriteLine($"{playerTwoName} chose {p2Choice}.");
                Console.WriteLine();
                Console.WriteLine("it's a tie! I can't believe it!");
            }
        }
        /// <summary>
        /// a method that takes a character choice ['1','2','3'] and return 
        /// corresponding character choice [1 = rock, 2 = paper, 3 = scissors]
        /// </summary>
        /// <param name="playerChoice">hidden char input</param>
        /// <returns>string conversion from char input</returns>
        static string ConvertChoiceToName(char playerChoice)
        {
            string choice;
            if (playerChoice == '1')
            {
                choice = "The Rock Bottom";
            }
            else if (playerChoice == '2')
            {
                choice = "Flying Leg Scissors";
            }
            else
            {
                choice = "Paper Tiger";
            }
            return choice;
        }
        // ui method
        /// <summary>
        /// A method that prints the main game banner, with the name of the game.
        /// </summary>
        static void PrintLargeWelcomeMessage()
        {
            Console.WriteLine("- - - - - - - - - - - -");
            Console.WriteLine();
            Console.WriteLine("          Mega         ");
            Console.WriteLine("        Rasslin'      ");
            Console.WriteLine("        Maniacs!       ");
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - -");

        }
        /// <summary>
        /// A method that prints the name of your game, all on one line.
        /// This will be used at the top of more than one game screen.
        /// </summary>
        static void PrintSmallHeader()
        {
            Console.WriteLine("----Mega Rasslin' Maniacs!----");

        }
        /// <summary>
        /// This method will show the menu options, prompt the user for a char key (visible). 
        /// Once it receives input, it should clear the console and return the char value entered by the user. 
        /// The char value will correlate to the menu choice.
        /// </summary>
        /// <returns>player input for menu choice</returns>
        static char ShowMenu()
        {
            char choice;
            Console.WriteLine();
            Console.WriteLine("1. One Player Game");
            Console.WriteLine("2. Two Player Game");
            Console.WriteLine("3. Game Rules");
            Console.WriteLine("4. Exit the Game");
            Console.WriteLine();
            choice = PromptForChar("Choose [1-4]: ");
            Console.Clear();
            return choice;
        }
        /// <summary>
        /// A method that prints the rules of the game, indicating which hands win or lose.
        /// </summary>
        static void PrintRules()
        {
            Console.WriteLine();
            Console.WriteLine("- - - - - - - Game Rules - - - - - - -");
            Console.WriteLine();
            Console.WriteLine("Make A Choice To See If It Beats Your Opponent");
            Console.WriteLine();
            Console.WriteLine("Rock Bottom beats Flying Leg Scissors");
            Console.WriteLine("Flying Leg Scissors beats Paper Tiger");
            Console.WriteLine("Paper Tiger beats the Rock Bottom");
            Console.WriteLine();
        }
        // ui screens
        /// <summary>
        /// A method that advertises a future single player DLC. returns player back to menu after 3 seconds.
        /// </summary>
        static void OnePlayerMode()
        {
            PrintSmallHeader();
            Console.WriteLine("- - - - -One Player Coming Soon- - - - -");
            Console.WriteLine("Look Out For it in the MEGA Rasslin' DLC");
            Thread.Sleep(3000);
            ShowMenu();
        }
        /// <summary>
        /// A method that runs the game with two players. Takes player inputs and uses separate methods to display results.
        /// </summary>
        static void TwoPlayerMode()
        {
            string playerOneName, playerTwoName;
            char playerOneChoice, playerTwoChoice;

            PrintSmallHeader();
            Console.WriteLine();
            playerOneName = PromptForString("What is Player One's Name?: ");
            playerTwoName = PromptForString("What is Player Two's Name?: ");
            Console.WriteLine();
            Console.Clear();
            PrintSmallHeader();
            Console.WriteLine($"{playerOneName} VERSUS {playerTwoName}");
            PrintRules();
            Console.WriteLine("--- Choose a value ---");
            Console.WriteLine("Press 1 for a Rock Bottom");
            Console.WriteLine("Press 2 for the Paper Tiger");
            Console.WriteLine("Press 3 for Flying Leg Scissors");
            do
            {
                playerOneChoice = PromptForCharHidden($"\n{playerOneName} - > : ");
            } while ((playerOneChoice < 0) && (playerOneChoice > 3));
            do
            {
                playerTwoChoice = PromptForCharHidden($"\n{playerTwoName} - > : ");
            } while ((playerTwoChoice < 0) && (playerTwoChoice > 3));
            Console.Clear();
            PrintSmallHeader();
            PrintResults(playerOneName, playerOneChoice, playerTwoName, playerTwoChoice);
            Console.WriteLine("do you want to play again Y for Yes or N for No");
            PressAnyKey();
                        
            Console.Clear();
        }
        /// <summary>
        /// A method that shows the rules of the game.
        /// </summary>
        static void RulesMode()
        {
            PrintSmallHeader();
            PrintRules();
            PressAnyKey();
            Console.Clear();
            ShowMenu();
        }
        /// <summary>
        /// A method that gives players an option to end the game.
        /// </summary>
        static void ExitOption()
        {
            PrintLargeWelcomeMessage();
            Console.WriteLine();
            Console.WriteLine("Thanks for playing");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
