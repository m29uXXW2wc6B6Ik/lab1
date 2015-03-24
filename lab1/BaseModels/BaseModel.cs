// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the BaseModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

/// <summary>
/// The BaseModels namespace.
/// </summary>
namespace Stelmashok.Generic.BaseModels
{
    /// <summary>
    /// Class BaseModel.
    /// </summary>
    public class BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseModel"/> class.
        /// </summary>
        public BaseModel()
        {
            this.Id = 1;
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
    }
}
