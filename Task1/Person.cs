using System;
namespace Task1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string firstName, string lastName, string email, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dob;
        }

        public Person(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public Person(string firstName, string lastName, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\nEmail: {Email}\nDate-Of-Birth: {DateOfBirth}";
        }




    }
}