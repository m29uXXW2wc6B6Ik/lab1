/// <summary>
/// The Generic namespace.
/// </summary>
namespace Stelmashok.Generic.Generic
{
    using Stelmashok.Generic.BaseModels;
    using Stelmashok.Generic.Cov_and_Contr;

    /// <summary>
    /// Class CovariantBaseModel.
    /// </summary>
    public class CovariantBaseModel : IGenericCovariant<BaseModel>
    {
        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>BaseModel.</returns>
        public BaseModel Create()
        {
            return new BaseModel();
        }
    }
}
