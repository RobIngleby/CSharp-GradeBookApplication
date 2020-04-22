using GradeBook.Enums;

using System;

namespace GradeBook.GradeBooks
{
    public  class RankedGradeBook:BaseGradeBook
    {

        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
   

        public override char GetLetterGrade(double averageGrade)
        {

            if (Students.Count > 5)
            {
                throw new InvalidOperationException("At least 5 students required");

            }
            return 'F'; // base.GetLetterGrade(averageGrade);
        }


    }
}

//In the RankedGradeBook class create an override for the GetLetterGrade method.

//The GetLetterGrade method returns a char and accepts a double named "averageGrade".

//If there are less than 5 students throw an InvalidOperationException. (Ranked-grading requires a minimum of 5 students to work)

//Return 'F' at the end of the method.
