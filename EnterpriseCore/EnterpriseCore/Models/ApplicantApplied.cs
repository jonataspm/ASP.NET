namespace EnterpriseCore.Models
{
    public class ApplicantApplied : BaseEntity
    {
        public Applicant Applicant { get; set; }
        public Work Work { get; set; }

    }
}