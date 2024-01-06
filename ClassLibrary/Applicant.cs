using System;

namespace ClassLibrary
{
    public class Applicant : Person
    {
        protected ZNO SertificateZNO;
        protected double AverageScoreInEducationDocument;
        protected string NameOfTheEducationalInstitution;
        
        public Applicant() : base()
        {
            SertificateZNO = new ZNO();
            AverageScoreInEducationDocument = 0;
            NameOfTheEducationalInstitution = "Unknown";
        }
        public Applicant(string firstName, string lastName, DateTime dateOfBirth, ZNO sertificateZNO, double avgScoreInEducationDocument, string nameOfTheEduacationalInstitution)
        : base(firstName, lastName, dateOfBirth)
        { 
            SertificateZNO = sertificateZNO;
            AverageScoreInEducationDocument = avgScoreInEducationDocument;
            NameOfTheEducationalInstitution = nameOfTheEduacationalInstitution;
        }
        public Applicant(Applicant applicant)
            : base(applicant.FirstName, applicant.LastName, applicant.DateOfBirth)
        {
            SertificateZNO = applicant.SertificateZNO;
            AverageScoreInEducationDocument = applicant.AverageScoreInEducationDocument;
            NameOfTheEducationalInstitution = applicant.NameOfTheEducationalInstitution;
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
            return NameOfTheEducationalInstitution;
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
            NameOfTheEducationalInstitution = nameOfTheEducationalInstitution;
        }
        public override string ShowInfo()
        {
            return base.ShowInfo() + "\n" + $"ZNO sertificate:\n{SertificateZNO.FirstSubjectName} - {SertificateZNO.FirstSubjectMark}\n{SertificateZNO.SecondSubjectName} - {SertificateZNO.SecondSubjectMark}\n{SertificateZNO.ThirdSubjectName} - {SertificateZNO.ThirdSubjectMark}" +
                $"\nAverage score in educational document: {AverageScoreInEducationDocument}" +
                $"\nName of the educational institution: {NameOfTheEducationalInstitution}";
        }
    }
}
