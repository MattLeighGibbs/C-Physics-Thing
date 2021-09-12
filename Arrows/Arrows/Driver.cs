using Love;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrows
{
    public class Driver : Scene
    {
        List<Ball> ball = new List<Ball>();
        public Driver()
        {
           

            for (int i =0; i < 100; i++)
            {
                ball.Add(new Ball());
            }
            Random random = new Random();

            ball.ForEach(a => a.acc = new System.Numerics.Vector2((float)random.NextDouble()/100, (float)random.NextDouble()/100));

        }

        public static void Main()
        {
            Boot.Run(new Driver());
        }

        public override void Draw()
        {
            base.Draw();
            ball.ForEach(a => a.move(this));
            ball.ForEach(b => Graphics.Print("@", b.pos.X, b.pos.Y));
        }
    }
}
