using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        int eP = 200;
 int wins = 0;
 int losses = 0;
 Menu(ref eP, ref wins, ref losses);
 }
 static void Menu(ref int eP, ref int wins, ref int losses)
 {
 string inputString;
 int gameChoice;

 //Allows the user to pick a game
 Console.WriteLine("Lets Play!");
 Console.WriteLine("Today's games consist of Pick Up Sticks & Mother May I");
 Console.WriteLine("Press 1 for Pick Up Sticks, 2 for Mother May I, 3 to look at the scoreboard, or 4 to Quit");
 inputString = Console.ReadLine();
 gameChoice = int.Parse(inputString);
 while (gameChoice != 1 && gameChoice != 2 && gameChoice != 3 && gameChoice != 4)
 {
 Console.WriteLine("Sorry wrong input, Press 1 for Pick Up Sticks, 2 for Mother May I, 3 to look at the scoreboard, or 4 to Quit ");
 inputString = Console.ReadLine();
 gameChoice = int.Parse(inputString);
 }
 while (gameChoice != 4)
 {
 if (gameChoice == 1)
 {
 eP = playSticks(eP, ref wins, ref losses);
 }
 else if (gameChoice == 2)
 {
 eP = playMotherMayI(eP, ref wins, ref losses);
 }
 else if (gameChoice == 3)
 {
 displayScoreBoard(eP, wins, losses);
 }
 else
 {
 Console.WriteLine("Press 4 to quit");
Console.ReadLine();
 }
 Console.WriteLine("Lets Play!");
 Console.WriteLine("Today's games consist of Pick Up Sticks & Mother May I");
 Console.WriteLine("Press 1 for Pick Up Sticks, 2 for Mother May I, 3 to look at the scoreboard, or 4to Quit");
 inputString = Console.ReadLine();
 gameChoice = int.Parse(inputString);
 }
 }
 //allows user to play Pick Up Sticks
 static int playSticks(int eP, ref int wins, ref int losses)
 {
 string inputString;
 int totalSticks = 0; //number of sticks left in the pile
 int userSum = 0;
 int compSum = 0;
 int compSticks = 0; //this is number of sticks computer picks up
 int userSticks = 0; //this is the number of sticks user picks up
 Console.WriteLine("Game rules: Player picks a number between 1 & 3 and then the player picks up the number of sticks chosen.");
 //this is displaying the game rules
 Console.WriteLine("Whoever has to pick up the last stick loses!"); //this is displaying the game rules
 Console.WriteLine("User picks number of sticks between 20-100.");
 inputString = Console.ReadLine();
 totalSticks = int.Parse(inputString);
 while (totalSticks < 20 || totalSticks > 100)
 {
 Console.WriteLine("Sorry wrong number choice");
 inputString = Console.ReadLine();
 totalSticks = int.Parse(inputString);
 }
 Console.WriteLine("How many sticks does user want to pick up between 1-3");
 inputString = Console.ReadLine();
 userSticks = int.Parse(inputString);
 while (userSticks < 1 || userSticks > 3)
 {
 Console.WriteLine("Sorry wrong number choice");
 inputString = Console.ReadLine();
 userSticks = int.Parse(inputString);
 }
 Console.WriteLine("This is how many sticks are left: " + totalSticks);
 userSticks = int.Parse(inputString);
 userSum = userSum + userSticks;
 while (totalSticks > 4) //while total sticks are greater than 4
 {
 Random randomNumbers = new Random();
 compSticks = randomNumbers.Next(1, 3);
 Console.WriteLine("Computer picks: " + compSticks + " sticks");
 compSum = compSum + compSticks;
 totalSticks = totalSticks - compSticks;
 Console.WriteLine("This is how many sticks are left: " + totalSticks);
 Console.WriteLine("How many sticks do you want to pick up?");
 inputString = Console.ReadLine();
 totalSticks = totalSticks - int.Parse(inputString);
 Console.WriteLine("This is how many sticks are left: " + totalSticks);
 userSticks = int.Parse(inputString);
 userSum = userSum + userSticks;
 }
 if (totalSticks == 4) //if total sticks is equal to 4
 {
 compSticks = 3;
 totalSticks = totalSticks - compSticks;
 compSum = compSum + compSticks;
 Console.WriteLine("Computer picks 3 sticks");
 Console.WriteLine("There is onely 1 stick left");
 Console.WriteLine("User must pick up one stick, user loses :(");
 Console.WriteLine("Computer wins!");
 eP = calculatePoints(eP, compSum);
 updateWinsLosses(ref wins, ref losses, "computer");

 }
 else if (totalSticks == 3) //if total sticks is equal to 3
 {
 compSticks = 2;
 totalSticks = totalSticks - compSticks;
 compSum = compSum + compSticks;
 Console.WriteLine("Computer picks 2 sticks");
 Console.WriteLine("There is only 1 stick left");
 Console.WriteLine("User must pick up one stick, user loses");
 Console.WriteLine("Computer wins");
 eP = calculatePoints(eP, compSum);
 updateWinsLosses(ref wins, ref losses, "computer");

 }
 else if (totalSticks == 2) //if total sticks is equal to 2
 {
 compSticks = 1;
 totalSticks = totalSticks - compSticks;
 compSum = compSum + compSticks;
 Console.WriteLine("Computer picks 1 stick");
 Console.WriteLine("There is only 1 stick");
 Console.WriteLine("User must pick up 1 stick, user loses");
 Console.WriteLine("Computer wins");
 eP = calculatePoints(eP, compSum);
 updateWinsLosses(ref wins, ref losses, "computer");
 }
 else if (totalSticks == 1) //if total sticks is equal to 1
 {
 compSticks = 1;
 totalSticks = totalSticks - compSticks;
 compSum = compSum + compSticks;
 Console.WriteLine("Computer picks 1 stick");
 Console.WriteLine("Computer must pick 1 stick, computer loses");
 Console.WriteLine("User wins");
 eP = calculatePoints(eP, -userSum);
 Console.WriteLine(eP);
 updateWinsLosses(ref wins, ref losses, "user");
 }
 Console.WriteLine("Press enter to display Menu");
 Console.ReadLine();
 return eP;
 }
 //allows user to play Mother May I
 static int playMotherMayI(int eP, ref int wins, ref int losses)
 {
 int userStep = 0; //this is how many steps users takes
 int compStep = 0; //this is how many steps computer takes
 int dieRoll; //this is the side the die landed on
 string userInput;
 Console.WriteLine("Game rules: Ecah player rolls a 10-sided die twice, then the player has an option to roll a 6-sided die.");
 //display rules of the game
 Console.WriteLine("Whoever has the closest number to 21 wins"); //display rules of thr game
 Console.WriteLine("This is the number of steps user has taken: " + userStep);
 Console.WriteLine("User rolls 10-sided die");
 Random randomNumbers = new Random();
 dieRoll = randomNumbers.Next(1, 10);
 userStep = dieRoll + userStep;
 Console.WriteLine("User takes " + dieRoll + " steps.");
 Console.WriteLine("User has moved: " + userStep + " steps.");
 Console.WriteLine("User rolls another 10-sided die");
 dieRoll = randomNumbers.Next(1, 10);
 userStep = dieRoll + userStep;
 Console.WriteLine("User takes " + dieRoll + " steps.");
 Console.WriteLine("User has moved: " + userStep + " steps.");
 Console.WriteLine("This is the number of steps computer has taken: " + compStep);
 Console.WriteLine("Computer rolls 10-sided die");
 dieRoll = randomNumbers.Next(1, 10);
 compStep = dieRoll + compStep;
 Console.WriteLine("Computer takes " + dieRoll + " steps.");
 Console.WriteLine("Computer has moved: " + compStep + " steps.");
 Console.WriteLine("Computer rolls another 10-sided die");
 dieRoll = randomNumbers.Next(1, 10);
 compStep = dieRoll + compStep;
 Console.WriteLine("Computer takes " + dieRoll + " steps.");
 Console.WriteLine("Computer has moved: " + compStep + " steps.");
 Console.WriteLine("Do you want to roll a six-sided die? Yes or No.");
 userInput = Console.ReadLine();
 while (userInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase)) //while user says yes
 {
 Console.WriteLine("User rolls 6-sided die");
 dieRoll = randomNumbers.Next(1, 6);
 userStep = dieRoll + userStep;
 Console.WriteLine("User rolled: " + dieRoll);
 Console.WriteLine("This is the number of steps user has taken: " + userStep);
 if (userStep > 21) //if userStep is greater than 21
 {
 Console.WriteLine("User loses 21 points");
eP = calculatePoints(eP, -21);
 Console.ReadLine();
 }
 else if (userStep < 21) //if userStep is less than 21
 {
 Console.WriteLine("Computers Turn");
Console.WriteLine("Computer rolls 6-sided die");
dieRoll = randomNumbers.Next(1, 6);
 compStep = dieRoll + compStep;
 Console.WriteLine("Computer takes " + dieRoll + " steps.");
 Console.WriteLine("Computer has moved: " + compStep + " steps.");

 Console.WriteLine("This is the number of steps computer has taken: " + compStep);
 }
 if (userStep < 21)
 {
 Console.WriteLine("This is the number of steps user has taken: " + userStep);
Console.WriteLine("Do you want to roll again? Yes or No.");
userInput = Console.ReadLine();
 }
 else
 {
 userInput.Equals("No", StringComparison.InvariantCultureIgnoreCase); //when user says no
Console.WriteLine("Computers Turn!");
 }
 }
 while (compStep < 17) //while compStep is less than 17
 {
 Console.WriteLine("Computers Turn");
 Console.WriteLine("Computer rolls 6-sided die");
 dieRoll = randomNumbers.Next(1, 6);
 compStep = dieRoll + compStep;
 Console.WriteLine("This is the number of steps computer has taken: " + dieRoll);
 Console.WriteLine("This is the total number of steps computer has taken: " + compStep);
 }
 if (userStep > compStep || userStep == 21) 
 //if suerStep is greater than compStep or userStep being equal to 21
 {
 Console.WriteLine("Congratulations User Won, Computer Lost");
 eP = calculatePoints(eP, -userStep);
 updateWinsLosses(ref wins, ref losses, "user");
 }
 else
 {
 Console.WriteLine("Sorry Computer Won, User Lost");
 int x = compStep;
 eP = calculatePoints(eP, x);
 updateWinsLosses(ref wins, ref losses, "computer");
 }
 Console.WriteLine("Press enter to display Menu");
 Console.ReadLine();
 return eP;
 }
 //this method is caculating the change in points and adding it to the energy points
 static int calculatePoints(int eP, int changeInPoints)
 {
 eP = changeInPoints + eP;
 return eP;
 }
 static void updateWinsLosses(ref int wins, ref int losses, string winner)
 {
 if (winner == "user")
 {
 wins++;
 }
 else
 {
 losses++;
 }
 }
 static void displayScoreBoard(int eP, int wins, int losses)
 {
 int woneP;
 woneP = eP - 200;

 Console.WriteLine("This is how much energy the children has left: " + eP);
 Console.WriteLine("This is how many games the babysitter has won: " + wins);
 Console.WriteLine("This is how many games the baby has won: " + losses);
 Console.WriteLine("Press enter to display Menu");
 Console.ReadLine();
 
 


                
        }
    }
}
