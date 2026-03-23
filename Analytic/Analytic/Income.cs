using System;

namespace Analytic
{
    /// <summary>
    /// Запись о получении дохода
    /// </summary>
    public class Income
    {
        /// <summary>
        /// Дата получения 
        /// </summary>
        public DateTime Date { get; }

        /// <summary>
        /// Суммав рублях
        /// </summary>
        public decimal Amount { get; }

        /// <summary>
        /// Имя плательщика
        /// </summary>
        public string FromWhom { get; }

        /// <summary>
        /// Тип плательщика 
        /// </summary>
        public PayerType PayerType { get; }

        /// <summary>
        /// Инициализирует новый доход
        /// </summary>
        /// <param name="date">Дата получения</param>
        /// <param name="amount">Сумма (только положительная)</param>
        /// <param name="fromWhom">Имя плательщика</param>
        /// <param name="payerType">Тип плательщика</param>
        public Income(DateTime date, decimal amount, string fromWhom, PayerType payerType)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма дохода должна быть положительной.", nameof(amount));

            Date = date;
            Amount = amount;
            FromWhom = fromWhom ?? throw new ArgumentNullException(nameof(fromWhom));
            PayerType = payerType;
        }
    }
}