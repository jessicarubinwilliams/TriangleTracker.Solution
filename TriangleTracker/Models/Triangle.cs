namespace TriangleTracker.Models
{
  public class Triangle
  {
    public int Side1 { get; }
    public int Side2 { get; }

    public Triangle(int side1, int side2)
    {
      Side1 = side1;
      Side2 = side2;
    }
  }
}