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
    public string TextUnderline { get; set; }
    public string TextInDepo { get; set; }
    public string EmptySchedule { get; set; }
    public string DeviationNote { get; set; }
    public string Star { get; set; }
    public string CNote { get; set; }
    public string HNote { get; set; }
    public string BNote { get; set; }
    public string DNote { get; set; }
    public string MNote { get; set; } 
    public string SchedulesFilePath { get; set; }
    public DateTime? DateLastUpdateSchedules { get; set; }
    public Visible Visible { get; set; }

    public ICollection<Route> Routes { get; set; }
    public ICollection<Station> Stations { get; set; }
}