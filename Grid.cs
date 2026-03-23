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
        // 2. Populate the grid
        for (int row = 0; row < 10; row++)
        {

            for (int col = 0; col < 10; col++)
            {
                // Assign a value to each cell
                starGrid[row, col] = "*   ";
            }
        }


        // 3. Traverse and print the grid to the console
        // for (int row = 0; row < 10; row++)
        // {
        //     for (int col = 0; col < 10; col++)
        //     {
        //         Console.Write($"{starGrid[row,col]:D2} ");
        //     }
        //     Console.WriteLine();
        // }
        //border
        string[] topEdge = Enumerable.Range(0, starGrid.GetLength(1))
                           .Select(colIndex => starGrid[0, colIndex])
                           .ToArray();
       
         for (int i = 0; i < topEdge.Length; i++)
         {
             Console.Write(topEdge[i]);

         };
      

    }
}
