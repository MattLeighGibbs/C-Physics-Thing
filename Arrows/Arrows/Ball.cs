using Arrows;
using Love;
public class RandomColorEntity : BasePhysics
{
    private static Random random = new Random();
    public RandomColorEntity()
    {
        color = GetRandomColor();
    }
  
    public Color color { get; set; }
  
    private Color GetRandomColor()
    {
        return new Color(rand(), rand(), rand(), rand());
    }

    private int rand()
    {
        return random.Next(0, 255);
    }
}