using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter Firstname: ");
            string fName = Console.ReadLine();
            Console.Write("Enter Lastname: ");
            string lName = Console.ReadLine();
            Console.Write("Enter Email: ");
            string mail = Console.ReadLine();



            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter Day: ");
            int day = int.Parse(Console.ReadLine());

            DateTime getDob = new DateTime(year, month, day);
            Person person = new Person(fName, lName, mail, getDob);
            GetDob(person.DateOfBirth);

            Console.Write("Employeee session");

            Console.Write("Enter Firstname: ");
            string eFName = Console.ReadLine();
            Console.Write("Enter Lastname: ");
            string eLName = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Payment Address");
            string pAddr = Console.ReadLine();


            Employee emp = new Employee(eFName, eLName, email, getDob,5000M, pAddr);
            emp.PaymetAddress();
            emp.RetrieveAmountDue(4000);
           


        }

        static void GetDob(DateTime getDob)
        {
             DateTime CurrentTime = DateTime.Now;
            int Age = new DateTime(CurrentTime.Subtract(getDob).Ticks).Year - 1;
            
            //Console.Write($"{Age}");

            if(getDob.Month == CurrentTime.Month && getDob.Day == CurrentTime.Day)
            {
                Console.WriteLine($"Your Age is: {Age}\nFantastic it is your Birthday\nHappy Birthday!!!");
                
            }else if(getDob.Year > CurrentTime.Year)
            {
                Console.WriteLine("Please input Correct Year. Your Year input has exceeded the current Year");
                
            }else if((CurrentTime.Year - getDob.Year ) >= 135)
            {
                Console.WriteLine("Age is above human existence limit");
            }else{
                Console.Write($"Your current Age is: {Age} Years");
                
            }

        }
    }
}
