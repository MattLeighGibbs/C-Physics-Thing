using Love;
using System.Numerics;
public class Ball
{
    public System.Numerics.Vector2 pos { get; set; }
    public System.Numerics.Vector2 vel { get; set; }
    public System.Numerics.Vector2 acc { get; set; }
    bool isFirstRun = true;

    public void move(Scene scene)
    {
        if (vel.X > 0 || isFirstRun)
        {
            vel = System.Numerics.Vector2.Add(new System.Numerics.Vector2(acc.X,0), vel);
        }
        if (vel.Y > 0 || isFirstRun)
        {
            vel = System.Numerics.Vector2.Add(new System.Numerics.Vector2(0, acc.Y), vel);
        }
        pos = System.Numerics.Vector2.Add(pos, vel);
        if (pos.X > Graphics.GetWidth() || pos.X < 0)
        {
            vel = System.Numerics.Vector2.Multiply(vel, new System.Numerics.Vector2(-1, 1));
            acc = System.Numerics.Vector2.Multiply(acc, new System.Numerics.Vector2(-1, 1));

            if (acc.X > 0)
            {
                acc = System.Numerics.Vector2.Subtract(acc, new System.Numerics.Vector2(.1f, 0));
            }
            else if(acc.X < 0)
            {
                acc = System.Numerics.Vector2.Subtract(acc, new System.Numerics.Vector2(-.1f, 0));

            }
            
            if (pos.X > Graphics.GetWidth())
            {
                pos = new System.Numerics.Vector2(Graphics.GetWidth(), pos.Y);
            }
            else
            {
                pos = new System.Numerics.Vector2(0, pos.Y);
            }

        }
        else if (pos.Y > Graphics.GetHeight() || pos.Y < 0)
        {
            vel = System.Numerics.Vector2.Multiply(vel, new System.Numerics.Vector2(1, -1));
            if (acc.Y > 0)
            {
                acc = System.Numerics.Vector2.Subtract(acc, new System.Numerics.Vector2(0, -.1f));
            }
            if (pos.Y > Graphics.GetHeight())
            {
                pos = new System.Numerics.Vector2(pos.X, Graphics.GetHeight());
            }
            else
            {
                pos = new System.Numerics.Vector2(pos.X, 0);
            }
        }
       
    }
}