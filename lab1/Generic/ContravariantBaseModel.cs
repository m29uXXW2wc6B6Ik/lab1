// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContravariantBaseModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ContravariantBaseModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

/// <summary>
/// The Generic namespace.
/// </summary>
namespace Stelmashok.Generic.Generic
{
    using Stelmashok.Generic.BaseModels;
    using Stelmashok.Generic.Cov_and_Contr;

    /// <summary>
    /// Class ContravariantBaseModel.
    /// </summary>
    public class ContravariantBaseModel : IGenericContravariant<BaseModel>
    {
        /// <summary>
        /// Gets the key.
        /// </summary>
        /// <param name="baseModel">The base model.</param>
        /// <returns>System.Int32.</returns>
        public int GetKey(BaseModel baseModel)
        {
            return baseModel.Id;
        }
    }
}
