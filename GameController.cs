using MakeGrid.Entities;

namespace MakeGrid.Game;

public class GameController
{
    private Grid grid;
    private Goomba goomba;

    public GameController()
    {
        grid = new Grid();
        goomba = new Goomba(0, 0); //star row, star col
    }
    public void Run()
    {
        while (true)
        {
            grid.ClearGrid();
            grid.DrawBorder();

            goomba.GoombaMove(grid.Rows, grid.Cols);
            goomba.GoombaDraw(grid.grid);

            grid.Print();

            Thread.Sleep(200);
            Console.Clear();
        }
    }
}
