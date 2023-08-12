using System.Collections.Generic;

namespace Lab4
{
    /// <summary>
    /// Класс OperatorContainer – представляет собой линейный список, хранящий
    /// объекты-операторы(экземпляры класса Operator)
    /// </summary>
    public static class OperatorContainer
    {
        public static List<Operator> operators = new List<Operator>();
        /// <summary>
        /// Статический конструктор. Заполняет список операторов.
        /// </summary>
        static OperatorContainer()
        {
            operators.Add(new Operator('S'));
            operators.Add(new Operator('M'));
            operators.Add(new Operator('D'));
            operators.Add(new Operator('I'));
            operators.Add(new Operator(','));
            operators.Add(new Operator('('));
            operators.Add(new Operator(')'));
        }
        /// <summary>
        /// Метод для поиска оператора по заданному символу в контейнере операторов
        /// </summary>
        /// <param name="s">Искомый символ</param>
        /// <returns>Возвращает оператор, знак которого совпал с искомым</returns>
        public static Operator FindOperator(char s)
        {
            foreach (Operator op in operators)
            {
                if(op.symbolOperator == s)
                {
                    return op;
                }
            }
            return null;
        }
    }
}
