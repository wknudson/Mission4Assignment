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

    if (string.IsNullOrEmpty(input) || input.Length == 0)
    {
        Console.WriteLine("Invalid input. Try again.");
        continue;
    }

    char move = input[0];
    // Check if input is a valid number between 1-9
    if (input.Length != 1)
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
        continue;
    }
    bool validMove = false;

    for (int i = 0; i < board.Length; i++)
    {
        if (board[i] == move)
        {
            board[i] = currentPlayer;
            turns++;
            validMove = true;
            break;
        }
    }

    if (!validMove)
    {
        Console.WriteLine("Invalid move. Position already taken or invalid number.");
        continue;
    }

    // Check for win BEFORE switching players
    char result = gt.checkWin(board);

    if (result == 'x')
    {
        gt.printCurrentBoard(board);
        Console.WriteLine("Player X wins!");
        gameWon = true;
    }
    else if (result == 'o')
    {
        gt.printCurrentBoard(board);
        Console.WriteLine("Player O wins!");
        gameWon = true;
    }
    else if (result == 'd' && turns == 9)  // Draw only when board is full
    {
        gt.printCurrentBoard(board);
        Console.WriteLine("Draw!");
        gameWon = true;
    }
    else
    {
        gt.printCurrentBoard(board);
        currentPlayer = currentPlayer == 'X' ? 'O' : 'X';  // Switch only if game continues
    }

} while (!gameWon && turns < 9);

Console.WriteLine("Thank you for playing Tic-Tac-Toe");