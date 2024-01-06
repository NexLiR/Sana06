using System;

namespace ClassLibrary
{
    public class LibraryUser : Person
    {
        protected int LibraryCardNumber;
        protected DateTime DateOfIssue;
        protected float MonthlyFee;
        public LibraryUser() : base()
        {
            LibraryCardNumber = 0;
            DateOfIssue = new DateTime(1901, 1, 1);
            MonthlyFee = 0;
        }
        public LibraryUser(string firstName, string lastName, DateTime dateOfBirth, int libraryCardNumber, DateTime dateOfIssue, float monthlyFee) 
            : base(firstName, lastName, dateOfBirth)
        {
            LibraryCardNumber = libraryCardNumber;
            DateOfIssue = dateOfIssue;
            MonthlyFee = monthlyFee;
        }
        public LibraryUser(LibraryUser libraryUser) 
            : base(libraryUser)
        {
            LibraryCardNumber = libraryUser.LibraryCardNumber;
            DateOfIssue = libraryUser.DateOfIssue;
            MonthlyFee = libraryUser.MonthlyFee;
        }
        public int GetLibraryCardNumber()
        {
            return LibraryCardNumber;
        }
        public DateTime GetDateOfIssue()
        {
            return DateOfIssue;
        }
        public float GetMonthlyFee()
        {
            return MonthlyFee;
        }
        public void SetLibraryCardNumber(int libraryCardNumber)
        {
            if (libraryCardNumber < 1)
            {
                throw new Exception("Library card number can not be less than 1!");
            }
            else LibraryCardNumber = libraryCardNumber;
        }
        public void SetDateOfIssue(DateTime dateOfIssue)
        {
            if (dateOfIssue > DateTime.Now)
            {
                throw new Exception("Date of issue can not be in the future!");
            }
            else DateOfIssue = dateOfIssue;
        }
        public void SetMonthlyFee(float monthlyFee)
        {
            if (monthlyFee < 0)
            {
                throw new Exception("Monthly fee can not be less than 0!");
            }
            else MonthlyFee = monthlyFee;
        }
        public override string ShowInfo()
        {
            return base.ShowInfo() + $"\nLibrary card number: {LibraryCardNumber:00000000}\nDate of issue: {DateOfIssue}\nMonthly fee: {MonthlyFee}";
        }
    }
}