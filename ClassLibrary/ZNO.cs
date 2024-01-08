using System;

namespace ClassLibrary
{
    public class ZNO
    {
        protected string _firstSubjectName;
        protected byte _firstSubjectMark;
        protected string _secondSubjectName;
        protected byte _secondSubjectMark;
        protected string _thirdSubjectName;
        protected byte _thirdSubjectMark;
        public string FirstSubjectName 
        {
            get 
            {
                return _firstSubjectName;
            }
            set
            {
                if (value.Length < 0)
                {
                    throw new Exception("First subject name cannot be empty");
                }
                else
                {
                    _firstSubjectName = value;
                }
            }
        }
        public byte FirstSubjectMark
        {
            get
            { 
                return _firstSubjectMark;
            }
            set 
            {
                if (value < 0 || value > 200)
                {
                    throw new Exception("First subject mark cannot be less than 0 or more than 200");
                }
                else
                {
                    _firstSubjectMark = value;
                }
            }
        }
        public string SecondSubjectName
        {
            get
            {
                return _secondSubjectName;
            }
            set
            {
                if (value.Length < 0)
                {
                    throw new Exception("Second subject name cannot be empty");
                }
                else
                {
                    _secondSubjectName = value;
                }
            }
        }
        public byte SecondSubjectMark
        {
            get
            {
                return _secondSubjectMark;
            }
            set
            {
                if (value < 0 || value > 200)
                {
                    throw new Exception("Second subject mark cannot be less than 0 or more than 200");
                }
                else
                {
                    _secondSubjectMark = value;
                }
            }
        }
        public string ThirdSubjectName
        {
            get
            {
                return _thirdSubjectName;
            }
            set
            {
                if (value.Length < 0)
                {
                    throw new Exception("Third subject name cannot be empty");
                }
                else
                {
                    _thirdSubjectName = value;
                }
            }
        }
        public byte ThirdSubjectMark
        {
            get
            {
                return _thirdSubjectMark;
            }
            set
            {
                if (value < 0 || value > 200)
                {
                    throw new Exception("Third subject mark cannot be less than 0 or more than 200");
                }
                else
                {
                    _thirdSubjectMark = value;
                }
            }
        }

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
