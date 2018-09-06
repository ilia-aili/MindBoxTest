using MindBoxTest_Libary.Exceptions;
using MindBoxTest_Libary.Figures.AbstractClassesAndInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest_Libary.Figures.Figures
{
    public class Triangle : Figure
    {
        private readonly bool _isRightAngled;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aSide">Сторона 1</param>
        /// <param name="bSide">Сторона 2</param>
        /// <param name="cSide">Сторона 3</param>
        public Triangle(double aSide, double bSide, double cSide)
        {
            if (IfInputParamsOk(aSide, bSide, cSide) == false)
                throw new InvalidInputForFigureException(this.GetType());

            ASide = aSide;
            BSide = bSide;
            CSide = cSide;

            //Высчитываем является треугольник прямоугольным

            //Чтобы не делать много if
            double[] sides = new double[3] { ASide, BSide, CSide };

            double biggestSide = sides.Max();
            double[] otherSides = sides.Where(side => side != biggestSide).ToArray();
            double sumOfSqrtsOfOtherSides = otherSides.Sum(side => Math.Pow(side, 2));

            _isRightAngled = (Math.Pow(biggestSide, 2) == sumOfSqrtsOfOtherSides);
        }

        protected override bool IfInputParamsOk(params double[] args)
        {
            foreach (double arg in args)
            {
                if (arg <= 0)
                    return false;
            }
            return true;
        }

        public override double Square
        {
            get
            {
                double halfOfPerimeter = (ASide + BSide + CSide) / 2;
                double m1 = halfOfPerimeter - BSide;
                double m2 = halfOfPerimeter - CSide;
                double m3 = halfOfPerimeter - ASide;
                return Math.Sqrt(halfOfPerimeter * m1 * m2 * m3);
            }
        }
        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightAngled
        {
            get
            {
                return _isRightAngled;
            }
        }
        public double ASide { get; private set; }
        public double BSide { get; private set; }
        public double CSide { get; private set; }
     

    }
}
