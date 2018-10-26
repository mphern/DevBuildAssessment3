using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    class Validator
    {
        public static int ValidateMinMax(string message, int min, int max)
        {
            int num;
            Console.Write(message);
            string answer = Console.ReadLine().Trim();
            while (!int.TryParse(answer, out num) || num < min || num > max)
            {
                Console.Write("Invalid input. " + message);
                answer = Console.ReadLine().Trim();
            }
            return num;
        }

        public static int ValidateInt(string message)
        {
            int num;
            Console.Write(message);
            string answer = Console.ReadLine().Trim();
            while (!int.TryParse(answer, out num) || num < 0)
            {
                Console.Write("Invalid input. " + message);
                answer = Console.ReadLine().Trim();
            }
            return num;
        }

        public static double ValidateDouble(string message)
        {
            double num;
            Console.Write(message);
            string answer = Console.ReadLine().Trim();
            while (!double.TryParse(answer, out num) || num < 0)
            {
                Console.Write("Invalid input. " + message);
                answer = Console.ReadLine().Trim();
            }
            return num;
        }

        public static bool ValidateBool(string message, string yes, string y, string no, string n)
        {
            Console.Write(message);
            string answer = Console.ReadLine().ToLower().Trim();
            while (answer != yes && answer != y && answer != no && answer != n)
            {
                Console.Write("Invalid input. " + message);
                answer = Console.ReadLine().ToLower().Trim();
            }
            if (answer == yes || answer == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
