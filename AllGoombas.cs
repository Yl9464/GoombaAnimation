using System.Runtime.InteropServices;
using IGoomba;
namespace DrawGoombas;

public class DrawGoombaFig : GoombaInterface
{

    private string[] goombaSprite;
    private int posX = 0; //horizontal movement

    public DrawGoombaFig()
    {
        goombaSprite = new string[10];

        goombaSprite[0] = @"     _________ ";
        goombaSprite[1] = @"    /         \ ";
        goombaSprite[2] = @"   /   \  /    \ ";
        goombaSprite[3] = @"  /    |  |     \ ";
        goombaSprite[4] = @" /  -^------^-   \ ";
        goombaSprite[5] = @"| ________________| ";
        goombaSprite[6] = @"      /      \     ";
        goombaSprite[7] = @"  ___|        |____ ";
        goombaSprite[8] = @"/____\  ====  /____\ ";
        goombaSprite[9] = @"                      ";
    }

    public void GoombaLeft()
    {
        goombaSprite = new string[10];

        goombaSprite[0] = @"     _________ ";
        goombaSprite[1] = @"    /         \ ";
        goombaSprite[2] = @"   /   \  /    \ ";
        goombaSprite[3] = @"  /    |  |     \ ";
        goombaSprite[4] = @" /  -^------^-   \ ";
        goombaSprite[5] = @"| ________________| ";
        goombaSprite[6] = @"  ____/      \       ";
        goombaSprite[7] = @" /____\       |____ ";
        goombaSprite[8] = @"        ====  /____\ ";
        goombaSprite[9] = @"                      ";

    }
    public void GoombaRight()
    {

        goombaSprite = new string[10];
        goombaSprite[0] = @"     _________ ";
        goombaSprite[1] = @"    /         \ ";
        goombaSprite[2] = @"   /   \  /    \ ";
        goombaSprite[3] = @"  /    |  |     \ ";
        goombaSprite[4] = @" /  -^------^-   \ ";
        goombaSprite[5] = @"| ________________| ";
        goombaSprite[6] = @"       /      \___       ";
        goombaSprite[7] = @"   ___|       /___\ ";
        goombaSprite[8] = @"  /___ \ ====   ";
        goombaSprite[9] = @"                      ";

    }

    public void DrawGoomba(int trailLength)
    {
        Console.Clear();

        for (int j = 0; j < trailLength; j++)
        {
            Console.Write(" * ");
        }
        Console.WriteLine(); // move to next line

        // Draw Goomba below
        for (int i = 0; i < goombaSprite.Length; i++)
        {
            Console.WriteLine(new string(' ', posX) + goombaSprite[i]);
        }
    }
    public void MoveGoomba(int steps, int delayMS = 200)
    {
        for (int x = 0; x < steps; x++)
        {
            posX = x * 3;

            if (x % 2 == 0)
                GoombaLeft();
            else
                GoombaRight();

            DrawGoomba(x); // trail grows on top

            Thread.Sleep(delayMS);
        }
    }

    // public void MoveLeft(int steps, int delayMs = 150)
    // {

    //     for (int i = 0; i < steps; i++)
    //     {
    //         if (posX > 0) posX--; //decrement, rmv spaces 

    //         if (i % 2 == 0) GoombaLeft();

    //         else GoombaRight();

    //     }
    //     DrawGoomba();
    //     Thread.Sleep(delayMs);

    // }
    // public void MoveDown(int steps, int delayMs = 150)
    // {
    //     for (int i = 0; i < steps; i++)
    //     {
    //         Console.WriteLine('*');
    //     }
    // }
}