using Love;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrows
{
    public class BasePhysics
    {
        public Vector2 pos { get; set; }
        public Vector2 vel { get; set; }
        public Vector2 acc { get; set; }

        public void move()
        {
            CheckBounds();

            vel = Vector2.Add(vel, acc);
            pos = Vector2.Add(pos, vel);
        }
        private void CheckBounds()
        {
            if (pos.X > Graphics.GetWidth() || pos.X < 0)
            {
                AdjustPos();
                FlipVector(vel, true);
                FlipVector(acc, true);
                ReduceAcceleration();
            }
            else if (pos.Y > Graphics.GetHeight() || pos.Y < 0)
            {
                AdjustPos();
                FlipVector(vel, false);
                ReduceAcceleration();
            }

        }
        private void FlipVector(Vector2 vector, bool flipX)
        {
            if (flipX)
            {
                vel = Vector2.Multiply(new Vector2(-1, 1), vector);
            }
            else
            {
                vel = Vector2.Multiply(new Vector2(1, -1), vector);
            }
        }
        private void ReduceAcceleration()
        {
            acc = Vector2.Subtract(acc, new Vector2(.001f, 0));
        }

        private void AdjustPos()
        {
            if (pos.X < 0)
            {
                pos = new Vector2(0, pos.Y);
            }
            else if (pos.X > Graphics.GetWidth())
            {
                pos = new Vector2(Graphics.GetWidth(), pos.Y);
            }
            if (pos.Y < 0)
            {
                pos = new Vector2(pos.X, 0);
            }
            else if (pos.Y > Graphics.GetHeight())
            {
                pos = new Vector2(pos.X, Graphics.GetHeight());
            }
        }
    }
}
