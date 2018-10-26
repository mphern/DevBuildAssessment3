using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    class TeamMember : Person
    {
        public double Salary { get; set; }
        public string Address { get; set; }

        public TeamMember(string firstName, string lastName, int age, string emailAddress, double salary, string address) : base(firstName, lastName, age, emailAddress)
        {
            Salary = salary;
            Address = address;
        }

        private static void AddtoList(string firstName, string lastName, int age, string emailAddress, double salary, string address, ref List<Person> list)
        {
            if (age > 18)
            {
                list.Add(new TeamMember(firstName, lastName, age, emailAddress, salary, address));
            }
            else
            {
                Console.WriteLine("Person is not over 18.  Cannot be added to the list");
            }

        }

        public static void CreateTeamMemberForList(ref List<Person> list)
        {
            bool goAgain = true;
            while (goAgain)
            {
                Console.Write("What is the Team Member's first name? ");
                string firstName = Console.ReadLine().Trim();

                Console.Write("What is the Team Member's last name? ");
                string lastName = Console.ReadLine().Trim();

                int age = Validator.ValidateInt("What is the Team Member's age? ");

                if (age > 18)
                {
                    Console.Write("What is the Team Member's email address? ");
                    string emailAddress = Console.ReadLine().Trim();

                    double salary = Validator.ValidateDouble("Enter Team Member's salary: ");

                    Console.Write("What is the What is the Team Member's address? ");
                    string address = Console.ReadLine().Trim();

                    AddtoList(firstName, lastName, age, emailAddress, salary, address, ref list);

                    Console.WriteLine("\n" + firstName + " has been added to the list!");
                }
                else
                {
                    Console.WriteLine("\nPerson is not older than 18.  Cannot be added to the list");
                }
                goAgain = Validator.ValidateBool("\nWould you like to add another Team Member to the list? (Y/N): ", "yes", "y", "no", "n");
            }
        }

        public override void Display()
        {
            Console.WriteLine("First: " + FirstName);
            Console.WriteLine("Last: " + LastName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Email Address: " + EmailAddress);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Address: " + Address);
        }
    }
}
