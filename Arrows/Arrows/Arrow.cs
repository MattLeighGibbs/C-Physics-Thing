using Love;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrows 
{
    public class Arrow : RandomColorEntity
    {
        public void exist()
        { 
            pos = Mouse.GetPosition();
            Graphics.Circle(DrawMode.Line, pos, 5);
        }
        
    }
}
