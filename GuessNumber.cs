namespace GuessNumberGame;

    public class GuessNumber {

        Random random = new();
        
        private int GenerateNum(int MaxNum) {
         
            int Number = random.Next(1, MaxNum);
            return Number;
        }
        private int GenerateNumLow() {
         
            int Number = random.Next(1, 11);
            return Number;
        }



        public int GuessingGameEasy() {
            int num = GenerateNumLow();
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

        public int ReplayGame() {
                        System.Console.WriteLine("Would you like to play again? Enter Y for yes, or N for no");
            string? replay = Console.ReadLine();
            if(replay == "Y") {
                System.Console.WriteLine("Enter your new Max value to set;");
                    string? newMax = Console.ReadLine();
                    int ReplayNum = Convert.ToInt32(newMax);
                    return ReplayNum;
            }
            if(replay == "N") {
            System.Console.WriteLine("Thank you for playing!");
            System.Threading.Thread.Sleep(1000);
            return 0;
            }
            else if (replay != "Y" || replay != "N") {
                System.Console.WriteLine("Try again; invalid selection");
                    ReplayGame();
            }
            return 0;
        }

        public void GuessingGameVariable(int MaxNum) {
            System.Console.WriteLine("Welcome to High/Low! Your range is set by what you passed into the game.");
                int num = GenerateNum(MaxNum);
                int Guess = 0;
                int tries = 0;
                string? input;
                System.Console.WriteLine($"I am thinking of a number between 1 to {MaxNum}, can you guess it quickly?");
                while(Guess != num) {

                    input = Console.ReadLine();
                    Guess = Convert.ToInt32(input);
                while(Guess > MaxNum | Guess < 1) {
                    System.Console.WriteLine($"Invalid number; try again between 1 and {MaxNum}");
                    input = Console.ReadLine();
                    Guess = Convert.ToInt32(input);
                }
                    tries ++;
                if(Guess > num && Guess - num >= 50) {
                    System.Console.WriteLine("You are not very close; too high.");
                }
                if(Guess > num && Guess - num >= 10 && Guess - num < 50) {
                    System.Console.WriteLine("You are close; too high.");
                }
                if(Guess > num && Guess - num <= 10) {
                    System.Console.WriteLine("You are very close; too high.");
                }
                if(Guess < num && num - Guess >= 50) {
                    System.Console.WriteLine("You are not very close; too low.");
                }
                if(Guess < num && num - Guess >= 10 && num - Guess < 50) {
                    System.Console.WriteLine("You are close; too low.");
                }
                if(Guess < num && num - Guess <= 10) {
                    System.Console.WriteLine("You are very close; too low.");
                }
                //need something for if the user inputs a letter/not a number.
                }
                if(Guess == num) { 
                    System.Console.WriteLine($"Correct! You are spot on. The number is {num} and it took you {tries} attempts");
                    if(tries < 10) 
                    System.Console.WriteLine("You did that very quickly; well done!");
                    if(tries >= 10 && tries < 25)
                    System.Console.WriteLine("Not bad, but I have seen better.");
                    if (tries > 25)
                    System.Console.WriteLine("Yikes, that was pretty bad.");
                }
            MaxNum = ReplayGame();
            if(MaxNum > 0) {
                GuessingGameVariable(MaxNum);
            }
            return;

        }
    }
