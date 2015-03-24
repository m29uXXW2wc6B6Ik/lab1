/// <summary>
/// The Generic namespace.
/// </summary>
namespace Stelmashok.Generic.Generic
{
    using Stelmashok.Generic.BaseModels;
    using Stelmashok.Generic.Cov_and_Contr;

    /// <summary>
    /// Class ContravariantChildModel.
    /// </summary>
    public class ContravariantChildModel : IGenericContravariant<ChildModel>
    {
        /// <summary>
        /// Gets the key.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <returns>System.Int32.</returns>
        public int GetKey(ChildModel t)
        {
            return t.Code + t.Id;
        }
    }
}
