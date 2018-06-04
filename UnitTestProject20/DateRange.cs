using System;

internal class BudgetModel
{
    public decimal TotalAmount()
    {
        var budget = new Budget { FirstDay = new DateTime(2018, 4, 1), LastDay = new DateTime(2018, 4, 30) };

        var dateRange = new DateRange(new DateTime(2018, 3, 31), new DateTime(2018, 5, 1));

        var overlappingDays = GetDays(dateRange, budget.FirstDay, budget.LastDay);

        return 0;
    }

    private int GetDays(DateRange dateRange, DateTime firstDay, DateTime lastDay)
    {
        
        if (dateRange.EndDate < firstDay)
        {
            return 0;
        }

        if (dateRange.StartDate > lastDay)
        {
            return 0;
        }

        return 32;
    }
}
internal class DateRange
{
    public DateTime StartDate { get; }
    public DateTime EndDate { get; }

    public DateRange(DateTime startDate, DateTime endDate)
    {
        StartDate = startDate;
        EndDate = endDate;
    }
}