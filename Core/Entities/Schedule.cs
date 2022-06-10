using Core.Entities.Enum;

namespace Core.Entities
{
    public class Schedule : BaseEntity
    {
        public int RouteId { get; set; }
        public TimeSpan Time { get; set; }
        public Period Period { get; set; }
        public int? Show { get; set; }
        public int? Hide { get; set; }
        public Day Day { get; set; }
        public Information Information { get; set; }
    }
}