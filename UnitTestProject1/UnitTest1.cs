using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareShape;

namespace UnitTestProject1
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void SquareTest()
        {
            var circle = new Circle("Круг", 3);
            circle.Square();
      
            var triangle = new Triangle("Треугольник", 3, 4, 5);
            triangle.IsStraightTriangle();
            
            var result = triangle.Square();
        }
    }
}
