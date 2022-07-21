namespace EnterpriseCore.Models
{
    public class Effort : BaseEntity
    {
        public TechnologyType TechnologyType { get; set; }
        public int Value { get; set; }
    }
}