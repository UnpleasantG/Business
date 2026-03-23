namespace Analytic
{
    /// <summary>
    /// Сервис аналитики по доходам самозанятого
    /// </summary>
    public interface IAnalyticsService
    {
        /// <summary>
        /// Отчет по доходам за указанный месяц
        /// </summary>
        /// <param name="incomes">Список всех доходов</param>
        /// <param name="year">Год</param>
        /// <param name="month">Месяц </param>
        /// <returns>Отчёт <see cref="MonthlyReport"/> за указанный месяц.</returns>
        MonthlyReport GetMonthlyReport(IEnumerable<Income> incomes, int year, int month);
    }
}