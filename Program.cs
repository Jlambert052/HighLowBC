System.Console.WriteLine("High or Low");

GuessNumberGame.GuessNumber guessNumber = new();

//Intro game version; 1-10
//guessNumber.GuessingGameEasy();

//Advanced game version; replay func and variable range
System.Console.WriteLine("Welcome to High or Low; your first game is finding the number 1 to 100.");

int MaxNum = int.Parse(args[0]);
guessNumber.GuessingGameVariable(MaxNum);
