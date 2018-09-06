using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxTest_Libary.Figures.Figures;
using MindBoxTest_Libary.Figures.AbstractClassesAndInterfaces;
using MindBoxTest_Libary.Exceptions;

namespace FigureUnitTests
{
    [TestClass]
    public class FigureUnitTests
    {
        [TestMethod]
        [Description("Проверка, правильно ли считается площадь треугольника")]
        public void IsTriangleSquareCorrect()
        {
            Figure figure = new Triangle(3,4,5);
            Assert.AreEqual(6, figure.Square);
        }
        [TestMethod]
        [Description("Проверка, правильно ли определяется что тр-к прямоугольный")]
        public void IsCheckThatTrianleIsRightAngledCorrect_1()
        {
            Triangle triangle = new Triangle(6, 8, 10);

            Assert.AreEqual(true, triangle.IsRightAngled);
        }
        [TestMethod]
        [Description("Проверка, правильно ли определяется что тр-к прямоугольный")]
        public void IsCheckThatTrianleIsRightAngledCorrect_2()
        {
            Triangle triangle = new Triangle(9, 8, 10);

            Assert.AreEqual(false, triangle.IsRightAngled);
        }
        [TestMethod]
        [Description("Проверка, что при передаче отрицательного значение в конструктор круга, выбросится исключение")]
        [ExpectedException(typeof(InvalidInputForFigureException))]
        public void IsCheckThatInputArgsValidationCorrect()
        {
            Figure figure = new Circle(-4);
        }
        [TestMethod]
        [Description("Проверка, что при передаче отрицательного значение в конструктор круга, исключения правильно хранит тип фигуры")]
      
        public void IsCheckThatInputExceptionHasCorrectTypeOfFigure()
        {
            try
            {
                Figure figure = new Circle(-4);
            }
            catch(InvalidInputForFigureException exception)
            {
                Assert.AreEqual(typeof(Circle), exception.TypeOfFigure);
            }
        }
    }
}
