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
      Triangle newTriangle = new Triangle();
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }
    
  }
}