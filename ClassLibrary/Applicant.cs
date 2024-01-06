using System;

namespace ClassLibrary
{
    public class Applicant : Person
    {
        protected ZNO SertificateZNO;
        protected double AverageScoreInEducationDocument;
        protected string NameOfTheFirstEducationalInstitution;
        
        public Applicant() : base()
        {
            SertificateZNO = new ZNO();
            AverageScoreInEducationDocument = 0;
            NameOfTheFirstEducationalInstitution = "Unknown";
        }
        public Applicant(string firstName, string lastName, DateTime dateOfBirth, ZNO sertificateZNO, double avgScoreInEducationDocument, string nameOfTheEduacationalInstitution)
        : base(firstName, lastName, dateOfBirth)
        { 
            SertificateZNO = sertificateZNO;
            AverageScoreInEducationDocument = avgScoreInEducationDocument;
            NameOfTheFirstEducationalInstitution = nameOfTheEduacationalInstitution;
        }
        public Applicant(Applicant applicant)
            : base(applicant.FirstName, applicant.LastName, applicant.DateOfBirth)
        {
            SertificateZNO = applicant.SertificateZNO;
            AverageScoreInEducationDocument = applicant.AverageScoreInEducationDocument;
            NameOfTheFirstEducationalInstitution = applicant.NameOfTheFirstEducationalInstitution;
        }
        public ZNO GetSertificateZNO()
        {
            return SertificateZNO;
        }
        public double GetAverageScoreInEducationDocument()
        {
            return AverageScoreInEducationDocument;
        }
        public string GetNameOfTheEducationalInstitution()
        {
            return NameOfTheFirstEducationalInstitution;
        }
        public void SetSertificateZNO(ZNO sertificateZNO)
        {
            SertificateZNO = sertificateZNO;
        }
        public void SetAverageScoreInEducationDocument(double avgScoreInEducationDocument)
        {
            AverageScoreInEducationDocument = avgScoreInEducationDocument;
        }
        public void SetNameOfTheEducationalInstitution(string nameOfTheEducationalInstitution)
        {
            NameOfTheFirstEducationalInstitution = nameOfTheEducationalInstitution;
        }
        public override string ShowInfo()
        {
            return base.ShowInfo() + "\n" + $"ZNO sertificate:\n{SertificateZNO.FirstSubjectName} - {SertificateZNO.FirstSubjectMark}\n{SertificateZNO.SecondSubjectName} - {SertificateZNO.SecondSubjectMark}\n{SertificateZNO.ThirdSubjectName} - {SertificateZNO.ThirdSubjectMark}" +
                $"\nAverage score in educational document: {AverageScoreInEducationDocument}" +
                $"\nName of the educational institution: {NameOfTheFirstEducationalInstitution}";
        }
    }
}
