namespace Topic_7_Structs_UnitTests
{
    public struct Tax
    {
        public decimal income;

        public Tax(decimal income)
        {
            this.income = income;
        }

        public decimal CalculateTax(decimal income)
        {
            decimal result = 0;

            if (income <= 100)
            {
                result = income * 0.1m;
            }
            else if (income > 150)
            {
                result = income * 0.2m;
            }

            return result;
        }
    }
}
