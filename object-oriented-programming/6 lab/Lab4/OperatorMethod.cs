namespace Lab4
{
    /// <summary>
    /// Сущность, хранящая в качестве свойств делегаты на методы с различным количетсвом параметров
    /// </summary>
    public class OperatorMethod
    {
        public delegate void EmptyOperatorMethod();
        public delegate void UnaryOperatorMethod(object operand);
        public delegate void BinaryOperatorMethod(object operand1, object operand2);
        public delegate void TrinaryOperatorMethod(object operand1, object operand2, object operand3);
    }
}
