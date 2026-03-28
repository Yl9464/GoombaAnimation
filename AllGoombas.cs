using System.Runtime.InteropServices;
using IGoomba;
namespace DrawGoombas;

public class DrawGoombaFig : GoombaInterface
{

    private string[] goombaSprite;
    private int posX = 0; //horizontal 
    private int posY = 0; //Vertical
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

    public void DrawGoombaDown()
    {
       // Console.Clear();
        // Draw trail ABOVE Goomba
        for (int j = 0; j < posY; j++)
        {
            Console.SetCursorPosition(posX, j);
            Console.Write("*");
        }

        // Draw Goomba at current position
        for (int i = 0; i < goombaSprite.Length; i++)
        {
            Console.SetCursorPosition(posX, posY + i);
            Console.Write(goombaSprite[i]);
        }
    }
    public void MoveGoombaRight(int steps, int delayMS = 200)
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

    public void MoveGoombaDown(int steps, int delayMS = 200)
    {
        posY = 0;

        for (int y = 0; y < steps; y++)
        {
            if (posY + goombaSprite.Length >= Console.WindowHeight)
                break; // stop at bottom

            posY++;

            if (y % 2 == 0)
                GoombaLeft();
            else
                GoombaRight();

            DrawGoombaDown();

            Thread.Sleep(delayMS);
        }
    }

}