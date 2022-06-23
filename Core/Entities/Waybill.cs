using Core.Entities.Enum;

namespace Core.Entities;
public class Waybill : BaseEntity
{
    public int Order { get; set; }
    public Day Day { get; set; }
    public Period Period { get; set; }
    public Station Station { get; set; }
    public int StationId { get; set; }
    public Route Route { get; set; }
    public int RouteId { get; set; }
    public ICollection<Interval> Intervals { get; set; }
}