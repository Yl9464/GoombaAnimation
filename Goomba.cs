// using IGoomba;

// namespace MakeGrid.Entities
// {
//     public class Goomba : GoombaInterface
//     {
//         private int row;
//         private int col;
//         private int direction = 1;

//         public Goomba(int startRow, int startCol)
//         {
//             row = startRow;
//             col = startCol;
//         }

//         public void GoombaMove(int maxRows, int maxCols)
//         {
//             col += direction;

//             if (col <= 1 || col >= maxCols - 2)
//             {
//                 direction *= -1;
//             }
//         }

//         public void GoombaDraw(char[,] grid)
//         {
//             grid[row, col] = 'G';
//         }
//     }
    
// }