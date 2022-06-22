namespace Core.Entities
{
    public class Time : BaseEntity
    {
        public TimeSpan? Start { get; set; }
        public TimeSpan? End { get; set; }
        public TimeSpan Value { get; set; }
        public Interval Interval { get; set; }
        public int IntervalId { get; set; }
    }
}