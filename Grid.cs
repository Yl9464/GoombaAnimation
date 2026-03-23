namespace MakeGrid;

public class Grid
{
    // 1. Declare and initialize a 10x10 integer grid
    //int[,] grid;
    string[,] starGrid;

    public Grid()
    {
        starGrid = new string[10, 10];
    }
    public void DrawGrid()

    {
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                // Check if it's a border cell
                if (row == 0 || row == 9 || col == 0 || col == 9)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  "); // empty inside
                }
            }
            Console.WriteLine(); // move to next row
        }
    }
}
