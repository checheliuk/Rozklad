using Core.Entities.Enum;

namespace Core.Entities;
public class Description : BaseEntity
{
    public string Text { get; set; }
    public Information Information { get; set; }
    public City City { get; set; }
    public int CityId { get; set; }
}