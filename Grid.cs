namespace MakeGrid;

public class Grid

{
    public int Rows = 11;
    public int Cols = 11;
    public char[,] grid; //2-D array of characters
    // (row, column)
    // (0,0) (0,1) (0,2) (0,3)
    // (1,0) (1,1) (1,2) (1,3)
    // (2,0) (2,1) (2,2) (2,3)
    public Grid()
    {
        grid = new char[Rows, Cols];
    }
    public void DrawGrid()
    {
        int rows = 10;
        int cols = 10;

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (r == 0 || r == rows - 1 || c == 0 || c == cols - 1)
                    Console.Write("* ");
                else
                    Console.Write("  ");
            }

            Console.WriteLine();
        }
    }
    public void ClearGrid()
    {
        for (int r = 0; r < Rows; r++) //loop thorugh every row and place * on left and right side 
            for (int c = 0; c < Cols; c++)
                grid[r, c] = ' ';
    }
    public void DrawBorder()
    {
        //drawing left and right borders
        for (int c = 0; c < Cols; c++)
        {
            grid[0, c] = '*'; //put * in row & r column 0
            grid[Rows - 1, c] = '*'; //acess the last column
        }
        for (int r = 0; r < Rows; r++)
        {
            grid[r, 0] = '*';
            grid[r, Cols - 1] = '*';
        }
    }
    public void Print()
    {
        for (int r = 0; r < Rows; r++)
        {
            for (int c = 0; c < Cols; c++)
                Console.Write(grid[r, c]);
            Console.WriteLine();

        }
    }
}