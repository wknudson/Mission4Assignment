// 1) The “Driver” class (the Program.cs class with the main method where the program begins) will:
//• Welcome the user to the game
//• Create a game board array to store the players’ choices
//• Ask each player in turn for their choice and update the game board array
//• Print the board by calling the method in the supporting class
//• Check for a winner by calling the method in the supporting class, and notify the players
//when a win has occurred and which player won the game


//using System.ComponentModel;

//Contain a method that prints the board based on the information passed to it 
//public void printCurrentBoard(char[] board)

//Contain a method that receives the game board array as input and returns if there is a winner and who it was
//public char checkWin(char[] board)
//Return ‘x’ ‘o’ or ‘d’ (else = no win)


//As always, write good, clean code with descriptive variable names, proper indentation, and clear
//commenting as appropriate to describe what the code is doing.

using Mission4Assignment;

GameTools gt = new GameTools();

//Welcome User
Console.WriteLine("Welcome to Tic-Tac-Toe!");

//Create Game Board
char[] board = [
    '1', '2', '3',
    '4', '5', '6',
    '7', '8', '9'
];
int turns = 0;
char currentPlayer = 'X';
bool gameWon = false;

gt.printCurrentBoard(board);

do
{
    Console.WriteLine($"Player {currentPlayer}, enter your move (1-9): ");
    string? input = Console.ReadLine();

} while (!gameWon && turns < 9);