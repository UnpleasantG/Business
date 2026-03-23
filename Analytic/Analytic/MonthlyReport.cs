namespace Analytic
{
    /// <summary>
    /// Отчёт по доходам за месяц
    /// </summary>
    public class MonthlyReport
    {
        /// <summary>Год отчета </summary>
        public int Year { get; }
        /// <summary>Месяц отчета </summary>
        public int Month { get; }
        /// <summary>Общая сумма доходов </summary>
        public decimal TotalIncome { get; }
        /// <summary>Налог с доходов от физ. лиц (4%.</summary>
        public decimal TaxFromIndividuals { get; }
        /// <summary>Налог с доходов от юр. лиц (6%)</summary>
        public decimal TaxFromLegalEntities { get; }
        /// <summary>Общая сумма налога к уплате</summary>
        public decimal TotalTax { get; }
        /// <summary>Прибыль </summary>
        public decimal Profit { get; }

        internal MonthlyReport(int year, int month, decimal totalIncome,
            decimal taxFromIndividuals, decimal taxFromLegalEntities,
            decimal totalTax, decimal profit)
        {
            Year = year;
            Month = month;
            TotalIncome = totalIncome;
            TaxFromIndividuals = taxFromIndividuals;
            TaxFromLegalEntities = taxFromLegalEntities;
            TotalTax = totalTax;
            Profit = profit;
        }
    }
}