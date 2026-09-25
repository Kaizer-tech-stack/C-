using System;

namespace AppDevCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n===== This is Grade Calculator =====");
            Console.WriteLine("Enter your student information like names, grades and the system will do the rest!\n");
            Console.Write("\nEnter your name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter your Prelim Grade: ");
            int prelimGrade = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter your Midterm Grade: ");
            int midtermGrade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Final Grade: ");
            int finalGrade = Convert.ToInt32(Console.ReadLine());

            int calculatedGrade = (prelimGrade + midtermGrade + finalGrade) / 3;
            

            if(calculatedGrade >= 75 || calculatedGrade >= 100)
            {
                Console.WriteLine("\n===== Student Information =====");
                Console.WriteLine("Your name is: " + studentName);
                Console.WriteLine("Average Grade: " + + calculatedGrade);
                Console.WriteLine("Status: PASSED!");
            }
            else
            {
                Console.WriteLine("\n===== Student Information =====");
                Console.WriteLine("Your name is: " + studentName);
                Console.WriteLine("Average Grade: " + calculatedGrade);
                Console.WriteLine("Status: FAILED!");
            }
        }
    }
}