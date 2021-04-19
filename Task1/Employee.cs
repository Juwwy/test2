using System;
namespace Task1
{
    public class Employee : Person, IPayable
    {
        private decimal salary;
        public string MailAddress { get; set; }
        public Employee(string firstName, string lastName, string email, DateTime dob, decimal salary, string mAddr) : base(firstName, lastName, email, dob)
        {
            this.Salary = salary;
            MailAddress = mAddr;
        }
        public Employee(string firstName, string lastName, string email) : base(firstName, lastName, email)
        {
            
        }

        public Employee(string firstName, string lastName, DateTime dob) : base(firstName, lastName, dob)
        {
            
        }

        public decimal Salary
        {
            get { return salary; }
            set {
                if(value > 0)
                {
                    salary = value;
                }else{
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public decimal RetrieveAmountDue(decimal amount)
        {
            return Salary - amount;
        }
        public decimal AddToAmountDue(decimal amount)
        {
            return Salary + amount;
        }
        public string PaymetAddress()
        {
            return MailAddress;
        }
    }
}