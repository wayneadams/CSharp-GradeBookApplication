// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RankedGradeBook.cs" company="PSCourse">
//   PSCourse
// </copyright>
// <summary>
//   Defines the RankedGradeBook type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GradeBook.GradeBooks
{
    using GradeBook.Enums;
    using System;
    using System.Linq;

    /// <summary>
    /// The ranked grade book.
    /// </summary>
    public class RankedGradeBook : BaseGradeBook
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RankedGradeBook"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public RankedGradeBook(string name) : base(name)
        {
            this.Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked Grading requires a minimum of 5 students to work");
            }

            var orderedStudents = this.Students.OrderByDescending(s => s.AverageGrade);
            var gradebucketSize = Students.Count / 5;

            if(averageGrade >= orderedStudents.ElementAt(gradebucketSize - 1).AverageGrade)
            {
                return 'A';
            } 
            if (averageGrade >= orderedStudents.ElementAt((gradebucketSize * 2) - 1).AverageGrade)
            {
                return 'B';
            }
            if (averageGrade >= orderedStudents.ElementAt((gradebucketSize * 3) - 1).AverageGrade)
            {
                return 'C';
            }
            if (averageGrade >= orderedStudents.ElementAt((gradebucketSize * 4) - 1).AverageGrade)
            {
                return 'D';
            }
            return 'F';
        }
    }
}
