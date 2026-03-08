namespace MakeGrid.Interfaces
{
    //goomba impements movement and drawing

    public interface IGoomba
    {
        void GoombaMove(int makeRows, int makeCols);
        void GoombaDraw(char[,] grid);
    }

}