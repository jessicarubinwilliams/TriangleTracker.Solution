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

    [TestMethod]
    public void SetSides_SetSides_Int()
    {
      int side1 = 0;
      int side2 = 0;
      int side3 = 0;
      Triangle newTriangle = new Triangle(side1, side2, side3);
      int updatedSide1 = 2;
      int updatedSide2 = 4;
      int updatedSide3 = 5;
      newTriangle.Side1 = updatedSide1;
      newTriangle.Side2 = updatedSide2;
      newTriangle.Side3 = updatedSide3;
      int result1 = newTriangle.Side1;
      int result2 = newTriangle.Side2;
      int result3 = newTriangle.Side3;
      Assert.AreEqual(updatedSide1, result1);
      Assert.AreEqual(updatedSide2, result2);
      Assert.AreEqual(updatedSide3, result3);
    }

    [TestMethod]
    public void CheckType_Determine3SidesNotTriangle_String()
    {
        int side1 = 3;
        int side2 = 9;
        int side3 = 22;
        Triangle newTriangle = new Triangle(side1, side2, side3);
        string result = newTriangle.CheckType();
        Assert.AreEqual("not a Triangle", result);
    }

    [TestMethod]
    public void CheckType_DetermineIfScalene_String()
    {
      int side1 = 4;
      int side2 = 5;
      int side3 = 7;
      Triangle newTriangle = new Triangle(side1, side2, side3);
      string result = newTriangle.CheckType();
      Assert.AreEqual("scalene triangle", result);
    }

    [TestMethod]
    public void CheckType_DetermineIfEquilateral_String()
    {
      int side1 = 5;
      int side2 = 5;
      int side3 = 5;
      Triangle newTriangle = new Triangle(side1, side2, side3);
      string result = newTriangle.CheckType();
      Assert.AreEqual("equilateral triangle", result);
    }
  }
}