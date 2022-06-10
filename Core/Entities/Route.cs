using Core.Entities.Enum;

namespace Core.Entities
{
    public class Route : BaseEntity
    {
        public string Name { get; set; }
        public string Translate { get; set; }
        public string Number { get; set; }
        public Transport Transport { get; set; }
        public int Order { get; set; }
        public int? ReverseId { get; set; }
        public bool Visible { get; set; }
    }
}