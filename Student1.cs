using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MenuDemo
{
    class Student1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public string Major { get; set; }
        public double Average { get; private set; }

        private List<int> scores;

        public List<Assignment> Scores
        {
            get { return scores; }
            set
            {
                scores = value;
                CalcAverage();
            }
        }

        /// <summary>
        /// Defaults StudentNumber to "Number Pending", names to "TBD" and Major to "Undeclared"
        /// </summary>
        public Student1()
            : this("Number Pending", "TBD", "TBD", "Undeclared")
        {
        }

        /// <summary>
        /// Defaults names to "TBD" and Major to "Undeclared"
        /// </summary>
        // <param name="sID">String representing students ID</param>
        public Student1(string sID)
            : this(sID, "TBD", "TBD", "Undeclared")
        {
        }

        /// <summary>
        /// Set all parameters except scores.
        /// </summary>
        // <param name="sID">String representing students ID</param>
        // <param name="firstName">Student's first name.</param>
        // <param name="lastName">Student's last name.</param>
        // <param name="maj">Student's major.</param>
        public Student1(string sID, string firstName, string lastName, string maj)
        {
            StudentNumber = sID;
            FirstName = firstName;
            LastName = lastName;
            Major = maj;
            scores = new List<int>();

        }

        /// <summary>
        /// Set all parameters including scores.
        /// </summary>
        /// <param name="sID">String representing students ID</param>
        /// <param name="firstName">Student's first name.</param>
        /// <param name="lastName">Student's last name.</param>
        /// <param name="maj">Student's major.</par
        /// <param name="score1">First score</param>
        /// <param name="score2">Second score</param>
        /// <param name="score3">Third score</param>
        /// <param name="maj"></param>
        public Student1(string sID, string firstName, string lastName,
            string maj, List<int> scores)
            : this(sID, firstName, lastName, maj)    
        {
            this.scores = scores;
            CalcAverage();
        }
        //#endregion

       // #region Instance Methods
        /// <summary>
        /// Calculates score average
        /// </summary>
        public void CalcAverage()
        {
            double sum = 0;
            foreach (Assignment assignment in scores)
            {
                sum += assignment.Score;
            }
            Average = sum / scores.Count;
        }

        /// <summary>
        /// Displays first name, last name, major and average.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return
                FirstName + " " + LastName
                + " Major: " + Major
                + " Average: " + Average.ToString("f2");
        }
        //#endregion
    }
}

