using GradeBook.Enums;

using System;
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

            return 'F';
        }// end GetLetterGrade
        
 

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
