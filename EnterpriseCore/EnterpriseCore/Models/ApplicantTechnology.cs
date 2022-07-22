namespace EnterpriseCore.Models
{
    public class ApplicantTechnology:BaseEntity
    {
        public Applicant Applicant { get; set; }
        public TechnologyType TechnologyType { get; set; }
    }
}