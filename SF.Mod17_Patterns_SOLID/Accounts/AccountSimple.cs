using SF.Mod17_Patterns_SOLID.Interfaces;

namespace SF.Mod17_Patterns_SOLID
{
    /// <summary>
    /// класс счета обычный
    /// </summary>
    public class AccountSimple : ICalculateInterest
    {
        // тип учетной записи
        public readonly string Type = "Обычный";

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        // Метод для расчета процентной ставки

        /// <summary>
        /// расчет ставки
        /// </summary>
        public void CalculateInterest()
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
    }
}
