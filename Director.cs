
namespace cse210_02
{
   public class Director
    {
        bool isPlaying = true;

        int score = 300;
        int points = 0;
        string userInput = "";
        Card randomCard1;
        Card randomCard2;


        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
    
            randomCard1 = new Card();
            randomCard2 = new Card();
           
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                Console.WriteLine($"The card is: {randomCard1.CardValue}");
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if the card is higher or lower
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Higher or lower? [h/l] ");
            userInput = Console.ReadLine();
            isPlaying = (userInput == "h" || userInput == "l");
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!isPlaying)
            {
                return;
            }
            
            if (randomCard2.CardValue > randomCard1.CardValue) {
                points = 100;
            }
            else if (randomCard2.CardValue < randomCard1.CardValue) {
                points = -75;
            }
            else {
                points = -75;
            }
            score += points;
            
            }
            

        /// <summary>
        /// Displays the card and the score. Also asks the player wants to continue 
        /// </summary>
        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }

            Console.WriteLine($"Next card was: {randomCard2.CardValue}");


            Console.WriteLine($"Your score is {score}");
            Console.WriteLine("Play again? [y/n]");
            string playAgain = Console.ReadLine();
            if (playAgain == "n") {
                isPlaying = false;
            }

        }
    }
}

