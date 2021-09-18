namespace TriangleTracker.Models
{
  public class Triangle
  {
    public int Side1 { get; }
    public int Side2 { get; }
    public int Side3 { get; }

    public Triangle(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }
  }
}