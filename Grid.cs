using DrawGoombas;

namespace MakeGrid;

public class Grid
{
    // 1. Declare and initialize a 10x10 integer grid
    DrawGoombaFig g;
    string[,] starGrid;
    int goombaMoveX = 0;
    int goombaMoveY = 0;
    bool start = true;
    public Grid()
    {
        g = new DrawGoombaFig();
        starGrid = new string[10, 10];
    }
    public void DrawGrid()
    {
        while (true)
        {
            Console.Clear();
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    // Check if it's a border cell
                    if (row == goombaMoveX && col == goombaMoveY)
                    {
                        Console.Write("G "); // player
                    }
                    else if (row == 0 || row == 9 || col == 0 || col == 9)
                    {
                        Console.Write("* "); // border
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            MoveAlongBorder();

        // ✅ Stop when back at start (but not immediately)
        // if (!start && playerRow == startRow && playerCol == startCol)
        //     break;

        // firstMove = false;
            Thread.Sleep(200);
        }
    }



    public void MoveAlongBorder()
    {
        // Top row → move right
        if (goombaMoveX == 0 && goombaMoveY < 9)
            goombaMoveY++;

        // Right column → move down
        else if (goombaMoveY == 9 && goombaMoveX < 9)
            goombaMoveX++;

        // Bottom row → move left
        else if (goombaMoveX == 9 && goombaMoveY > 0)
            goombaMoveY--;

        // Left column → move up
        else if (goombaMoveY == 0 && goombaMoveX > 0)
            goombaMoveX--;
        
    }
}