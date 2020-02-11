using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradeBook.Enums;


namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name):base(name)
        {
            Type = GradeBookType.Ranked; 
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException("min number of students is 5");

            int rank = Students.Count;
            var grades = Students.OrderByDescending(x => x.AverageGrade).Select(x => x.AverageGrade).ToList();
            

            if (averageGrade > grades[(int)Math.Ceiling(rank * 0.2)-1])
                return 'A';
            else if (averageGrade > grades[(int)Math.Ceiling(rank * 0.4)-1])
                return 'B';
            else if (averageGrade > grades[(int)Math.Ceiling(rank * 0.6)-1])
                return 'C';
            else if (averageGrade > grades[(int)Math.Ceiling(rank * 0.8)-1])
                return 'D';
            else
                return 'F';
        }
    }
}
