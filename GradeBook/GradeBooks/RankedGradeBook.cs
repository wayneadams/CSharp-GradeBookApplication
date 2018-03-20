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
    }
}
