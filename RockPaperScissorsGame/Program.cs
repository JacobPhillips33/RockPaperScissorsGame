using RockPaperScissorsGame;

//Initiates the game and capture user's choice
Console.Write("Let's play Rock, Paper, Scissors! Please enter your choice: ");
var userChoice = Console.ReadLine().ToLower();
Console.WriteLine();

//Makes initial random computer choice
string computerChoice = Methods.ComputerChoice();

bool letsPlay = true; //Conditional for if user wants to play

while (letsPlay)
{
    //TODO - Ensure the user entry is valid -- the below code is not working correctly
            //while (userChoice != "rock" || userChoice != "paper" || userChoice != "scissors")
            //{
            //    Console.WriteLine("Please make a valid entry of 'rock,' 'paper,' or 'scissors.' Try again:");
            //    userChoice = Console.ReadLine().ToLower();
            //}


    //Runs through the scenarios
    while (userChoice == computerChoice)
    {
        Console.Write($"We both chose {userChoice}. We tied. Choose again: ");
        userChoice = Console.ReadLine().ToLower();
        computerChoice = Methods.ComputerChoice();
        Console.WriteLine();
    }

    if (userChoice == "rock")
    {
        if (computerChoice == "scissors")
        {
            Console.WriteLine("Rock breaks scissors. You win!");
        }
        else
        {
            Console.WriteLine("Paper covers rock. Computer wins.");
        }
    }
    else if (userChoice == "paper")
    {
        if (computerChoice == "rock")
        {
            Console.WriteLine("Paper covers rock. You win!");
        }
        else
        {
            Console.WriteLine("Scissors cuts paper. Computer wins.");
        }
    }
    else
    {
        if (computerChoice == "paper")
        {
            Console.WriteLine("Scissors cuts paper. You win!");
        }
        else
        {
            Console.WriteLine("Rock breaks scissors. Computer wins.");
        }
    }

    Console.Write("Would you like to play again? ");
    var userAnswer = Console.ReadLine();
    Console.WriteLine();

    if (userAnswer == "yes")
    {
        letsPlay = true;
        Console.Write("Please enter your choice: ");
        userChoice = Console.ReadLine().ToLower();
        computerChoice = Methods.ComputerChoice();
        Console.WriteLine();
    }
    else
    {
        letsPlay = false;
    }
}
Console.WriteLine("Thanks for playing. Have a great day!");









