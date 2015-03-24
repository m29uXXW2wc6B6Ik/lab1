/// <summary>
/// The BaseModels namespace.
/// </summary>
namespace Stelmashok.Generic.BaseModels
{
    /// <summary>
    /// Class ChildModel.
    /// </summary>
    public class ChildModel : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChildModel"/> class.
        /// </summary>
        public ChildModel()
        {
            this.Code = 1;
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>The code.</value>
        public int Code { get; set; }
    }
}
