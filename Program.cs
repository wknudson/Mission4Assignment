//Section 1 group 10
//James, Josh, Brady, & Will
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