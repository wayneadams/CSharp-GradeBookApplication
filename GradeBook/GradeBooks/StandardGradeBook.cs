// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StandardGradeBook.cs" company="PSCourse">
//   PSCourse
// </copyright>
// <summary>
//   Defines the StandardGradeBook type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GradeBook.GradeBooks
{
    using GradeBook.Enums;

    /// <summary>
    /// The standard grade book.
    /// </summary>
    public class StandardGradeBook : BaseGradeBook
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardGradeBook"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public StandardGradeBook(string name) : base(name)
        {
            this.Type = GradeBookType.Standard;
        }
    }
}
