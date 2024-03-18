const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors: ");
string playerChoice = Console.ReadLine();

if (playerChoice == "r" || playerChoice == "Rock" || playerChoice == "R" || playerChoice == "rock")
{
    playerChoice = Rock;
}

else if (playerChoice == "p" || playerChoice == "Paper" || playerChoice == "P" || playerChoice == "paper")
{
    playerChoice = Paper;
}

else if (playerChoice == "s" || playerChoice == "Scissors" || playerChoice == "S" || playerChoice == "scissors")
{
    playerChoice = Scissors;
}

else
{
    Console.WriteLine("Invalid Input. Try Again...");
    return;
}

Random random = new Random();
int computerRandomNumber = random.Next(1, 4);

string computerMove = "";

switch (computerRandomNumber)
{
    case 1:
        computerMove = Rock;
        break;

    case 2:
        computerMove = Paper;
        break;

    case 3:
        computerMove = Scissors;
        break;
}

Console.WriteLine($"The computer chose {computerMove}.");

if (playerChoice == Rock && computerMove == Scissors || playerChoice == Paper && computerMove == Rock || playerChoice == Scissors && computerMove == Paper)
{
    Console.WriteLine("You win.");
}

else if (playerChoice == Paper && computerMove == Scissors || playerChoice == Rock && computerMove == Paper || playerChoice == Scissors && computerMove == Rock)
{
    Console.WriteLine("You lose.");
}

else
{
    Console.WriteLine("This game was a draw.");
}