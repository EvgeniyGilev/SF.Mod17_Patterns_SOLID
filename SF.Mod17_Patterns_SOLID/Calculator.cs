using SF.Mod17_Patterns_SOLID.Interfaces;

namespace SF.Mod17_Patterns_SOLID
{
    /// <summary>
    /// Класс с методом расчета ставки
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Метод для расчета ставки
        /// </summary>
        /// <param name="calculateInterest">The calculate interest.</param>
        public void Calculate(ICalculateInterest calculateInterest)
        {
            calculateInterest.CalculateInterest();
        }
    }
}
