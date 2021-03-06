using Core.Entities.Enum;

namespace API.Dtos;
public class RouteDto
{
    public int Id { get; set; }
    public int? ReverseId { get; set; }
    public string Name { get; set; }
    public string Translate { get; set; }
    public string Number { get; set; }
    public Transport Transport { get; set; }
    public int Order { get; set; }
}