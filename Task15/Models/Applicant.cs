namespace Task15.Models
{
    public class Applicant
    {
        public int SchoolNumber { get; private set; }
        public int AdmissionYear { get; private set; }
        public string Surname { get; private set; }
        public Applicant(int schoolNumber, int admissionYear, string surname)
        {
            SchoolNumber = schoolNumber;
            AdmissionYear = admissionYear;
            Surname = surname;
        }
    }
}
