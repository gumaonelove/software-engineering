namespace Lab4
{
    /// <summary>
    /// Класс Operator – представляет собой объект-оператор. Данный класс будет хранить
    /// знак оператора и переменную каждого делегата, унаследованного от класса OperatorMethod
    /// </summary>
    public class Operator : OperatorMethod
    {
        public char symbolOperator;
        public EmptyOperatorMethod operatorMethod = null;
        public BinaryOperatorMethod binaryOperator = null;
        public TrinaryOperatorMethod trinaryOperator = null;
        /// <summary>
        /// Конструктор для оператора, выполняющего метод, не принимающий параметров
        /// </summary>
        /// <param name="operatorMethod">Метод, не принимабщий параметров</param>
        /// <param name="symbolOperator">Знак оператора</param>
        public Operator(EmptyOperatorMethod operatorMethod, char symbolOperator)
        {
            this.operatorMethod = operatorMethod;
            this.symbolOperator = symbolOperator;
        }
        /// <summary>
        /// Конструктор, использующийся при обработке входной строки
        /// </summary>
        /// <param name="symbolOperator">Знак оператора</param>
        public Operator(char symbolOperator)
        {
            this.symbolOperator = symbolOperator;
        }
    }
}
