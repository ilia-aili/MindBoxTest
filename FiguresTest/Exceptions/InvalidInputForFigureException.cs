using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest_Libary.Exceptions
{
    // Делаю его public, так как, возможно клиент захочет его обрабатывать
    // Так как под каждый тип фигуры делать кастомное исключение не очень, стараюсь его обобщить
    /// <summary>
    /// Базовый класс для исключения неправильного задания сторон(радиуса) для фигуры
    /// </summary>
    public class InvalidInputForFigureException: Exception
    {
     
        public InvalidInputForFigureException(Type T):base()
        {
            TypeOfFigure = T;
        }
        public override string Message
        {
            get
            {
                return $"Один или несколько параметров для фигуры типа {TypeOfFigure.Name} являются некорректными";
            }
        }
        public Type TypeOfFigure { get; private set; }
    }
}
