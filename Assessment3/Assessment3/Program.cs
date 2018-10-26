using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();
            bool goAgain = true;
            while(goAgain)
            {
                DisplayMenu();
                int choice = Validator.ValidateMinMax("\nWhat would you like to do? (Enter 1-4): ", 1, 4);
                Console.WriteLine("\n");

                if (choice == 1)
                {
                    Person.CreatePersonForList(ref peopleList);
                }

                else if (choice == 2)
                {
                    TeamMember.CreateTeamMemberForList(ref peopleList);
                }

                else if(choice == 3)
                {
                    if (peopleList.Count == 0)
                    {
                        Console.WriteLine("There are currently no people on the list.");
                    }
                    else
                    {
                        DisplayList(peopleList);
                    }
                }

                else
                {
                    break;
                }

                goAgain = Validator.ValidateBool("\nWould you like to continue? (Y/N): ", "yes", "y", "no", "n");
                Console.WriteLine("\n");
                if(goAgain)
                {
                    Console.Clear();
                }
            }
            Console.WriteLine("\nGood bye!");
            Console.ReadKey();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("        Menu         ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("1. Add Person to List");
            Console.WriteLine("2. Add Team Member to List");
            Console.WriteLine("3. See List of People");
            Console.WriteLine("4. Quit");
        }


        static void DisplayList(List<Person> list)
        {
            foreach(Person person in list)
            {
                person.Display();
                Console.WriteLine("\n");
            }
        }

    }
}
