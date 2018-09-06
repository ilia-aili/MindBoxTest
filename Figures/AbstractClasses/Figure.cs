using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest_Libary.Figures.AbstractClassesAndInterfaces
{
    // Так как в задаче сказано что есть юнит- тест на добавление новых фигур,
    // я делаю вывод что  клиент для вычислений будет использовать сущности, а не набор параметров(длина, ширина, и тд)
    /// <summary>
    /// Класс, выделяющий абстракцию для геометрической фигуры
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public abstract double Square { get;}
        // Задаю что длины(радиус) для фигур могут быть приведены к double
        // Надеюсь это не очень страшно
        // Так же не делаю обобщенную проверку на то что параметры  меньше или равны нулю,
        // т к возможно захотим создавать другие фигуры где корректность
        // проверяется соотношением величин ее сторон 
        /// <summary>
        ///  Проверка корректны ли входные параметры для фигуры
        /// </summary>
        /// <param name="args">Входные параметры</param>
        /// <returns></returns>
        protected abstract bool IfInputParamsOk(params double[] args);
    }
}
