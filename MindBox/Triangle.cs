using System;

namespace MindBox
{
    public static class Triangle
    {
        public static double СalcArea(double a, double b, double c)
        {
            if (!isItTriangle(a, b, c))
                throw new ArgumentOutOfRangeException("Это не треугольник! Проверьте парамметры.");

            if (!isItRightTriangle(a, b, c))
                throw new ArgumentOutOfRangeException("Это не прямоугольный треугольник! Проверьте парамметры.");

            return calcAreaByGeron(a, b, c);
        }

        /// <summary>
        /// проверка корректности введенных параметров
        /// </summary>
        /// <param name="a">сторона 1</param>
        /// <param name="b">сторона 2</param>
        /// <param name="c">сторона 3</param>
        /// <returns></returns>
        private static bool isItTriangle(double a, double b, double c)
        {
            return ((a + b >= c) && (a + c >= b) && (c + b >= a) && a >= 0 && b >= 0 && c >= 0);
        }

        /// <summary>
        /// Возвращает true, если треугольник прямоугольный
        /// </summary>
        /// <param name="a">сторона 1</param>
        /// <param name="b">сторона 2</param>
        /// <param name="c">сторона 3</param>
        /// <returns></returns>
        private static bool isItRightTriangle(double a, double b, double c)
        {
            double[] sides = new double[] { a, b, c };
            Array.Sort(sides);
            return (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2));
        }


        /// <summary>
        /// Вычисляет площадь по формуле Герона
        /// </summary>
        /// <param name="a">сторона 1</param>
        /// <param name="b">сторона 2</param>
        /// <param name="c">сторона 3</param>
        /// <returns></returns>
        private static double calcAreaByGeron(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
        }
    }
}
