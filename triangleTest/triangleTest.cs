using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using assignment2_tri;

namespace triangleTest
{
    [TestFixture]
    public class triangleTest
    {
        [Test]
        public void testEquilateralTriangle()
        {
            Assert.AreEqual(TriangleSolver.Analyze(5, 5, 5), "Equilateral Triangle");

        }

        [Test]
        public void testIsocelesTriangle()
        {
            Assert.AreEqual(TriangleSolver.Analyze(5, 5, 6), "Isosceles Triangle");

        }

        [Test]
        public void testScaleneTriangle()
        {
            Assert.AreEqual(TriangleSolver.Analyze(2, 3, 4), "Scalene Triangle");
        }

        [Test]
        public void testTriangle()
        {
            Assert.AreEqual(TriangleSolver.Analyze(2, 4, 24), "Invalid input. Triangle cant be formed.");
        }

        [Test]
        public void testSide1_Triangle()
        {
            Assert.AreEqual(TriangleSolver.Analyze(6, 0, 2), "Triangles sides should be greater than 0.");
        }

        [Test]
        public void testSide2_Triangle()
        {
            Assert.AreEqual(TriangleSolver.Analyze(0, 6, 2), "Triangles sides should be greater than 0.");
        }

        [Test]
        public void testSide3_Triangle()
        {
            Assert.AreEqual(TriangleSolver.Analyze(6, 2, 0), "Triangles sides should be greater than 0.");
        }

        [Test]
        public void testNegativeSide_Triangle()
        {
            Assert.AreEqual(TriangleSolver.Analyze(-6, -2, -10), "Triangles sides should be greater than 0.");
        }


    }
}
