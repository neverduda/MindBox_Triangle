using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBox;

namespace TestMindBox
{
    [TestClass]
    public class TriangleTest
    {
        /// <summary>
        /// Несуществующий треугольник
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestWrongParameters()
        {
            Triangle.СalcArea(1, 2, 1);
        }

        /// <summary>
        /// Отрицательные параметры
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMinusParameters()
        {
            Triangle.СalcArea(1, -1, 1);
        }

        /// <summary>
        /// не прямоугольный треугольник
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNotRightTriangle()
        {
            Triangle.СalcArea(1, 1, 1);
        }

        /// <summary>
        /// ОК
        /// </summary>
        [TestMethod]
        public void TestCorrectTriangle()
        {
            Triangle.СalcArea(8, 15, 17);
        }
    }
}
