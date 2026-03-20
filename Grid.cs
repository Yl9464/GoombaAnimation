namespace MakeGrid;

public class Grid
{
    // 1. Declare and initialize a 10x10 integer grid
    int[,] grid;
    public Grid()
    {
        grid = new int[10, 10];
    }
    public void DrawGrid()
    {
        // 2. Populate the grid
        for (int row = 0; row < 10; row++)
        {

            for (int col = 0; col < 10; col++)
            {
                // Assign a value to each cell
                grid[row, col] = row * 10 + col;
            }
        }


        // 3. Traverse and print the grid to the console
        for (int row = 0; row < 10; row++)
        {
            if (row == 0)
                for (int col = 0; col < 10; col++)
                {
                    Console.Write(" * ");
                }
        }
    }
}
