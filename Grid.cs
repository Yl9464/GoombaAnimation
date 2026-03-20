namespace MakeGrid;

public class Grid
{

    // 1. Declare and initialize a 10x10 integer grid
    int[,] grid;
    public Grid()
    {
        grid = new int[10, 10];
    }
    public void DrawGrid() {
        // 2. Populate the grid (e.g., assign values based on their position)
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                // Assign a value to each cell (e.g., a simple value for demonstration)
                // Here, we can use the row number, column number, or something else.
                grid[row, col] = row * 10 + col;
            }
        }

        // 3. Traverse and print the grid to the console
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                // Print the value in each cell, formatted for alignment
                Console.Write($"{grid[row, col],-4}");
            }
            // Move to the next line after each row
            Console.WriteLine();
        }
    }
}