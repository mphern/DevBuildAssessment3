using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }
        private bool IsAnAdult { get; set; }

        public Person(string firstName, string lastName, int age, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            EmailAddress = emailAddress;
        }

        public bool OverEighteen()
        {
            if(Age > 18)
            {
                IsAnAdult = true;
                return true;
            }
            else
            {
                IsAnAdult = false;
                return false;
            }
        }

        public static void CreatePersonForList(ref List<Person> list)
        {
            bool goAgain = true;
            while (goAgain)
            {
                Console.Write("What is the person's first name? ");
                string firstName = Console.ReadLine().Trim();

                Console.Write("What is the person's last name? ");
                string lastName = Console.ReadLine().Trim();

                int age = Validator.ValidateInt("What is the person's age? ");

                if (age > 18)
                {
                    Console.Write("What is the person's email address? ");
                    string emailAddress = Console.ReadLine().Trim();

                    AddtoList(firstName, lastName, age, emailAddress, ref list);

                    Console.WriteLine("\n" + firstName + " has been added to the list!");
                }
                else
                {
                    Console.WriteLine("\nPerson is not older than 18.  Cannot be added to the list\n");
                }
                goAgain = Validator.ValidateBool("\nWould you like to add another person to the list? (Y/N): ", "yes", "y", "no", "n");
            }
        }

        private static void AddtoList(string firstName, string lastName, int age, string emailAddress, ref List<Person> list)
        {
            if(age > 18)
            {
                list.Add(new Person(firstName, lastName, age, emailAddress));
            }
            else
            {
                Console.WriteLine("Person is not over 18.  Cannot be added to the list");
            }

        }

        public virtual void Display()
        {
            Console.WriteLine("First: "+ FirstName);
            Console.WriteLine("Last: " + LastName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Email Address: " + EmailAddress);
        }

    }
}
