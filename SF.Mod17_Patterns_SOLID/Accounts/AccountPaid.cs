using SF.Mod17_Patterns_SOLID.Interfaces;

namespace SF.Mod17_Patterns_SOLID
{
    /// <summary>
    /// класс счета зарплатный
    /// </summary>
    public class AccountPaid : ICalculateInterest
    {
        // тип учетной записи
        public readonly string Type = "Зарплатный";

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        /// <summary>
        /// расчет процентной ставки зарплатного аккаунта по правилам банка
        /// </summary>
        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
