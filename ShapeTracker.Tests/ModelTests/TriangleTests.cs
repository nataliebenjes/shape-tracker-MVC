using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
    [TestClass]
    public class TriangleTests
    {
        // Tests will go here!
        [TestMethod]
        public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
        {
            Triangle newTriangle = new Triangle();
            Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
        }
    }
}