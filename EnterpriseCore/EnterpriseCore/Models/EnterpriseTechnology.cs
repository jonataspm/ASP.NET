namespace EnterpriseCore.Models
{
    public class EnterpriseTechnology : BaseEntity
    {
        public Enterprise Enterprise { get; set; }

        public TechnologyType TechnologyType { get; set; }
    }
}