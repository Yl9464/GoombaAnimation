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


    public void DrawGoomba()
    {
        Console.Clear();
         
         Console.Clear();
        foreach (string line in goombaSprite)
        {
            Console.WriteLine(new string(' ', posX) + line); //Replace @ with ' ' at index 0

        }

    }
      public void Draw()
    {
        DrawGoomba();
    }

}