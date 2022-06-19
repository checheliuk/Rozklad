namespace Core.Entities.Enum
{
    [Flags]
    public enum Day : int
    {
        None = 0,
        WorkingDays = 1,
        WeekendDays = 2
    }
}