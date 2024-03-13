namespace Outguess {
    internal class Program {
        static void Main(string[] args) {


            int randNum = Rand();
            int numberOfGuesses = 7;
            int guess = 0;
            int age = 0;
            Print("Welcome to Outguess: The Wilson Family Edition!");
            Print("");
            age = InputInt("Please enter your age: ");

            if (age == 1) {
                Print("Kaleb, can you even read this???");

            } else if (age == 6) {
                Print("What's going on Zack?! I heard you really liked candy corn...");
            } else if (age == 9) {
                Print("Layla!!! I'm glad you took a break from drawing to come play with me...");
            } else if (age == 10) {
                Print("Hi, Ava!!! I'm not exactly \"My Singing Monsters\", but I PROMISE I'm fun!!!");
            } else if (age == 17) {
                Print("Quinton's playing with me and not on his PHONE?!?! OHHHHHHHHH SNAP!!!!");
            } else if (age == 36) {
                Print("Greetings, Creator...please don't delete me if I make your family mad!!!");
            } else if (age == 39) {
                Print("Are you \"Mommy\"?? Weird way to spell \"Goddess\", but it's fine...");
            
            } else {
                Print("Ugh....I guess the Wilsons let just ANY old body play on here smh...");
            }

            Print("____________________________________________________________________________________________________________________");

            Console.WriteLine("I've chosen a secret number between 1-200...I'll give you seven tries to figure it out....now guess it!");
            Print("");

            do {
                guess = InputInt("Enter your guess: ");
                numberOfGuesses--;

                if (guess > randNum) {
                    Print($"Sorry, too high! You have {numberOfGuesses} guesses remaining.");
                } else if (guess < randNum) {
                    Print($"Sorry, too low! You have {numberOfGuesses} guesses remaining.");


                }

            } while (numberOfGuesses > 0 && guess != randNum);

            if (guess == randNum) {
                Console.ForegroundColor = ConsoleColor.Green;
                Print($"YOU WIN!!! My number was {randNum}");
                Console.ResetColor();
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Print($"You Lose! The correct number was {randNum}");
                Console.ResetColor();
            }



            #region HELPER FUNCTIONS

            static string Input(string message) {
                Console.Write(message);
                return Console.ReadLine();
            }//end function

            static decimal InputDecimal(string message) {
                string value = Input(message);
                return decimal.Parse(value);
            }//end function

            static double InputDouble(string message) {
                string value = Input(message);
                return double.Parse(value);
            }//end function

            static int InputInt(string message) {
                string value = Input(message);
                return int.Parse(value);
            }//end function

            static string Print(string message) {
                Console.WriteLine(message);
                return message;
            }//end function

            static int Rand() {
                Random rand = new Random();
                return rand.Next(1, 201);
            }//end function
            #endregion
        }//end main
    }//end class
}//end namespace