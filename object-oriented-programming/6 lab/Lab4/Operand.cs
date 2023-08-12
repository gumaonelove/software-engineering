namespace Lab4
{
    /// <summary>
    /// Класс Operand – представляет собой объект-операнд, в котором будет 
    /// храниться значение для операнда из входной строки.
    /// </summary>
    public class Operand
    {
        public object value;
        /// <summary>
        /// Конструктор операнда, иницилизирующий его значение.
        /// </summary>
        /// <param name="NewValue">Значение для данного операнда</param>
        public Operand(object NewValue)
        {
            value = NewValue;
        }
    }
}
