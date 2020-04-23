using GradeBook.Enums;

using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {

        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("You must have at least 5 students to do ranked grading.");
            }


        //    int tyveProcent = Students.Count * (20 / 100); // 20 %
              var tyveProcent = (int)Math.Ceiling(Students.Count * 0.2);
        
            var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();

            if (averageGrade >= grades[tyveProcent - 1])
                 return 'A';
            if (averageGrade >= grades[(tyveProcent * 2) - 1])
                return 'B';
            if (averageGrade >= grades[(tyveProcent * 3) - 1])
                return 'C';
            if (averageGrade >= grades[(tyveProcent * 4) - 1])
                return 'D';
            return 'F';
        }// end GetLetterGrade

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
             base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
        
        
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            base.CalculateStudentStatistics(name);
        }


    } //end class
}// end nspace

//(One way to solve this is to figure out how many students make up 20%,
//    then loop through all the grades and check how many scored higher 
//    than the input average,
//    every N students where N is that 20% value drop a letter grade.)

//Ranked-grading grades students not based on their individual performance, 
//    but rather their performance compared to their peers.
//    This means the 20% of the students with the highest grade of a class get an A,
//    the next highest 20% get a B, etc.
//  
//There are many ways to calculate this.
//        I'd recommend figuring out how many students it takes to drop a letter grade
//        (20% of the total number of students) X, put all the average grades in order,
//    then figure out where the input grade would fit in the series of grades. 
//    Every X students with higher grades than the input grade knocks the letter grade
//    down until you reach F.




//In the RankedGradeBook class create an override for the GetLetterGrade method.

//The GetLetterGrade method returns a char and accepts a double named "averageGrade".

//If there are less than 5 students throw an InvalidOperationException. (Ranked-grading requires a minimum of 5 students to work)

//Return 'F' at the end of the method.
