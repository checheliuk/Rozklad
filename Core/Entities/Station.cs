namespace Core.Entities
{
    public class Station : BaseEntity
    {
        public string Name { get; set; }
        public string Translate { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
       
        public ICollection<Interval> Intervals { get; set; }
    }
}