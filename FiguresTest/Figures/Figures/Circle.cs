using MindBoxTest_Libary.Exceptions;
using MindBoxTest_Libary.Figures.AbstractClassesAndInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest_Libary.Figures.Figures
{
   public class Circle : Figure
    {
      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            if (IfInputParamsOk(radius) == false)
                throw new InvalidInputForFigureException(this.GetType());
            Radius = radius;
        }

        public override double Square
        {
            get
            {
                // Не стал делать двойку как константу, надеюсь ничего страшного
                return Math.PI * Math.Pow(Radius, 2);
            }
        }
        public double Radius { get; private set; }

        protected override bool IfInputParamsOk(params double[] args)
        {
            foreach (double arg in args)
            {
                if (arg <= 0)
                    return false;
            }
            return true;
        }
    }
}
