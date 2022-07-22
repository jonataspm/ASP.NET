namespace EnterpriseCore.Models
{
    public class Effort : BaseEntity
    {
        public Work Work { get; set; }
        public TechnologyType TechnologyType { get; set; }
        public int Value { get; set; }
    }
}