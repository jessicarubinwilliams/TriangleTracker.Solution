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
      Triangle newTriangle = new Triangle(2);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void TriangleConstructor_ReturnsSide1_Int()
    {
      int side1 = 2;
      Triangle newTriangle = new Triangle(side1);
      int result = newTriangle.Side1;
      Assert.AreEqual(side1, result);
    }

  }
}