using System;
using System.Collections.Generic;
using System.Text;

namespace Slotkin_StudentClassDemo
{
    class Student 
    {  
        private string firstName;
        private string lastName;
        private string idNumber;
        private string major;
        private string results;
        private List<int> scores;  
        private double averageScore;
        public Student()
        {

        }

        public string FirstName
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }

        public string IdNumber
        {
            get; set;
        }

        public string Major  
        {
            get; set;
        }

        public List<int> Scores
        {
            get { return scores; }
            set
            {
                bool isValid = true;
                foreach(int score in value)
                {
                    isValid = isValid && score >= 0 && score <= 100;
                }
                if (isValid)
                {
                    scores = value;  
                    UpdateAverageScore();
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Scores must be between 0 and 100");
                }
            }
        }

        public string Results()
        {
            results = "Hello, " + firstName + lastName + "! ID: " + idNumber + " Major: " + major + ".";
            return results;
        }

        public double GetAverageScore()
        {
            return this.averageScore;
        }

        private void UpdateAverageScore()
        {
            this.averageScore = (scores[0] + scores[1]) / 2;
        }       

        public static void DoStuff()
        {
            Student molly = new Student();
            molly.firstName = "Molly";
            molly.idNumber = "42";
            Console.WriteLine("Molly: {0}", molly.firstName);
            Console.WriteLine("Molly: {0}", molly.idNumber);

            Student someStudent = new Student();
            someStudent.firstName = "Unknown";
            someStudent.idNumber = "Unknown";
            Console.WriteLine("someStudent: {0}", someStudent.firstName);
            Console.WriteLine("someStudent: {0}", someStudent.idNumber);

        }
    }
}
