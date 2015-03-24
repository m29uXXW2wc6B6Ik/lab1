/// <summary>
/// The Generic namespace.
/// </summary>
namespace Stelmashok.Generic.Generic
{
    using Stelmashok.Generic.BaseModels;
    using Stelmashok.Generic.Cov_and_Contr;

    /// <summary>
    /// Class CovariantChildModel.
    /// </summary>
    public class CovariantChildModel : IGenericCovariant<ChildModel>
    {
        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>ChildModel.</returns>
        public ChildModel Create()
        {
            return new ChildModel();
        }
    }
}
