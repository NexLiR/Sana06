using System;

namespace ClassLibrary
{
    public class ZNO
    {
        public string FirstSubjectName { get; set; }
        public byte FirstSubjectMark { get; set; }
        public string SecondSubjectName { get; set; }
        public byte SecondSubjectMark { get; set; }
        public string ThirdSubjectName { get; set; }
        public byte ThirdSubjectMark { get; set; }

        public ZNO()
        {
            FirstSubjectName = "Undefined";
            FirstSubjectMark = 200;
            SecondSubjectName = "Undefined";
            SecondSubjectMark = 200;
            ThirdSubjectName = "Undefined";
            ThirdSubjectMark = 200;
        }
        public ZNO(string firstSubjectName, byte firstSubjectMark, string secondSubjectName, byte secondSubjectMark, string thirdSubjectName, byte thirdSubjectMark)
        {
            FirstSubjectName = firstSubjectName;
            FirstSubjectMark = firstSubjectMark;
            SecondSubjectName = secondSubjectName;
            SecondSubjectMark = secondSubjectMark;
            ThirdSubjectName = thirdSubjectName;
            ThirdSubjectMark = thirdSubjectMark;
        }
        public ZNO(ZNO sertificateZNO)
        {
            FirstSubjectName = sertificateZNO.FirstSubjectName;
            FirstSubjectMark = sertificateZNO.FirstSubjectMark;
            SecondSubjectName = sertificateZNO.SecondSubjectName;
            SecondSubjectMark = sertificateZNO.SecondSubjectMark;
            ThirdSubjectName = sertificateZNO.ThirdSubjectName;
            ThirdSubjectMark = sertificateZNO.ThirdSubjectMark;
        }
    }
}
