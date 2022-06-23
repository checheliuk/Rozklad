namespace Core.Entities
{
    public class Interval : BaseEntity
    {
        public TimeSpan? Start { get; set; }
        public TimeSpan? End { get; set; }
        public TimeSpan Time { get; set; }
        public Waybill Waybill { get; set; }
        public int WaybillId { get; set; }
    }
}