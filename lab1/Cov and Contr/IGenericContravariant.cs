/// <summary>
/// The Cov_and_Contr namespace.
/// </summary>
namespace Stelmashok.Generic.Cov_and_Contr
{
    using Stelmashok.Generic.BaseModels;

    /// <summary>
    /// Interface IGenericContravariant
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericContravariant<in T> where T : BaseModel
    {
        int GetKey(T t);
    }
}
