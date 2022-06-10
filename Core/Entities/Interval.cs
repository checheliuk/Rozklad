using Core.Entities.Enum;

namespace Core.Entities
{
    public class Interval : BaseEntity
    {
        public int RouteId { get; set; }
        public int StationId { get; set; }
        public int Order { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
        public TimeSpan Time { get; set; }
        public Day Day { get; set; }
    }
}