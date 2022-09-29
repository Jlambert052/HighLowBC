namespace GuessNumberGame;

    public class GuessNumber {

        Random random = new();
        
        private int GenerateNum() {
         
            int Number = random.Next(1, 11);
            return Number;
        }

        public int GuessingGame() {
            int num = GenerateNum();
            int Guess = 0;
            int tries = 0;
            System.Console.WriteLine("I am thinking of a number from 1 to 10; can you guess what it is?");
            while(Guess != num) {
                System.Console.WriteLine("Your guess: ");
            string? guessnum = Console.ReadLine();
                Guess = Convert.ToInt32(guessnum);
                tries ++;

                if(Guess > num) {
                    System.Console.WriteLine("Too high! Try again.");
                }
                if(Guess < num ) {
                    System.Console.WriteLine("Too low! Try again.");
                }
                if(Guess == num)
                System.Console.WriteLine($"Correct! {Guess} was the number. That took you {tries} times to guess.");
            }
            
            return Guess;

        }
    }