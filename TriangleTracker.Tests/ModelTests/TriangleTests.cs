using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTracker.Tests 
{
  [TestClass]
  public class TriangleTests
  {
    
    [TestMethod]
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    {
      Triangle newTriangle = new Triangle(2,4,5);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void TriangleConstructor_ReturnsSide1_Int()
    {
      int side1 = 2;
      Triangle newTriangle = new Triangle(side1, 4, 5);
      int result = newTriangle.Side1;
      Assert.AreEqual(side1, result);
    }

[TestMethod]
    public void TriangleConstructor_ReturnsSide2_Int()
    {
      int side1 = 2;
      int side2 = 4;
      Triangle newTriangle = new Triangle(side1, side2, 5);
      int result = newTriangle.Side2;
      Assert.AreEqual(side2, result);
    }

    [TestMethod]
    public void TriangleConstructor_ReturnsSide3_Int()
    {
      int side1 = 2;
      int side2 = 4;
      int side3 = 5;
      Triangle newTriangle = new Triangle(side1, side2, side3);
      int result = newTriangle.Side3;
      Assert.AreEqual(side3, result);
    }

  }
}