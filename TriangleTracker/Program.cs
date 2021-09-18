using System;
using TriangleTracker.Models;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Determine if 3 lengths make a triangle.");
      Console.WriteLine("Length of side 1: ");
      string stringSide1 = Console.ReadLine();
      int side1 = int.Parse(stringSide1);
      Console.WriteLine("Length of side 2: ");
      string stringSide2 = Console.ReadLine();
      int side2 = int.Parse(stringSide2);
      Console.WriteLine("Length of side 3: ");
      string stringSide3 = Console.ReadLine();
      int side3 = int.Parse(stringSide3);
      Triangle userTriangle = new Triangle(side1, side2, side3);
      Console.WriteLine(userTriangle.CheckType());
    }
  }
}