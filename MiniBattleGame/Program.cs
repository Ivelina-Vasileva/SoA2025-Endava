namespace MiniBattleGame
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int playerScore = 0;
            int enemyScore = 0;
            int evenRollsCount = 0;

            for (int round = 1; round <= 5; round++)
            {
                Console.WriteLine($"Round {round}");

                int playerRoll = RollDice();
                int enemyRoll = RollDice();

                if (playerRoll % 2 == 0)
                {
                    evenRollsCount++;
                }

                if (enemyRoll % 2 == 0)
                {
                    evenRollsCount++;
                }

                int result = BattleRound(playerRoll, enemyRoll);

                if (result == 1)
                {
                    playerScore++;
                }
                else if (result == -1)
                {
                    enemyScore++;
                }

                if (round < 5)
                {
                    Console.WriteLine("Click Enter to continue to the next round...");
                    Console.ReadKey();
                }
            }
            AnnounceWinner(playerScore, enemyScore, evenRollsCount);
        }

        private static Random random = new Random();

        private static int RollDice()
        {
            return random.Next(1, 7);
        }

        private static int BattleRound(int playerRoll, int enemyRoll)
        {
            Console.WriteLine($"Player rolled: {playerRoll}, Enemy rolled: {enemyRoll}");

            if (playerRoll > enemyRoll)
            {
                Console.WriteLine("Player wins the round!");
                return 1;
            }
            else if (enemyRoll > playerRoll)
            {
                Console.WriteLine("Enemy wins the round!");
                return -1;
            }
            else
            {
                Console.WriteLine("It's a tie!");
                return 0;
            }
        }

        private static void AnnounceWinner(int playerScore, int enemyScore, int evenRollsCount)
        {
            Console.WriteLine($"Final Score: player {playerScore} - enemy {enemyScore}");

            if (evenRollsCount == 5)
            {
                Console.WriteLine(($"The total number of even rolls is {evenRollsCount}. Tie is declared"));
            }
            else if (playerScore > enemyScore)
            {
                Console.WriteLine("WINNER: *** PLAYER ***");
            }
            else if (enemyScore > playerScore)
            {
                Console.WriteLine("WINNER: *** ENEMY ***");
            }
            else
            {
                Console.WriteLine("*** THE GAME ENDS IN A TIE ***");
            }
        }
    }
}