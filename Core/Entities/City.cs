using Core.Entities.Enum;

namespace Core.Entities;
public class City : BaseEntity
{
    public string Name { get; set; }
    public string Translate { get; set; }
    public string Url { get; set; }
    public Period Period { get; set; }
    public Print Print { get; set; }
    public string GoogleMaps { get; set; }
    public string SchedulesFilePath { get; set; }
    public DateTime? DateLastUpdateSchedules { get; set; }
    public Visible Visible { get; set; }

    public ICollection<Route> Routes { get; set; }
    public ICollection<Station> Stations { get; set; }
    public ICollection<Description> Descriptions { get; set; }
}