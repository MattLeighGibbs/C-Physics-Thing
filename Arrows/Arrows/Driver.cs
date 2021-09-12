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
        private static Random random = new Random();

        //List<Ball> ball = new List<Ball>();
        //public Driver()
        //{

        //    for (int i =0; i < 100; i++)
        //    {
        //        ball.Add(new Ball());
        //    }
        //    Random random = new Random();

        //    ball.ForEach(a => a.acc = new Vector2((float)random.NextDouble() / 100, (float)random.NextDouble() / 100));
        //}

        public static void Main()
        {
            Boot.Run(new Driver());
        }
        int x;
        int y;
        public Arrow aimer = new Arrow();
        public override void Draw()
        { 
            Graphics.Circle(DrawMode.Line, new Vector2(x, y), 5);
            if (Keyboard.IsDown(KeyConstant.S))
            {
                y += 5;
            }
            if (Keyboard.IsDown(KeyConstant.W))
            {
                y -= 5;
            }
            if (Keyboard.IsDown(KeyConstant.A))
            {
                x -= 5;
            }
            if (Keyboard.IsDown(KeyConstant.D))
            {
                x += 5;
            }
            aimer.exist();
        }

        

    }
}
