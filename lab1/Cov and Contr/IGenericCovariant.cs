/// <summary>
/// The Cov_and_Contr namespace.
/// </summary>
namespace Stelmashok.Generic.Cov_and_Contr
{
    using Stelmashok.Generic.BaseModels;

    /// <summary>
    /// Interface IGenericCovariant
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericCovariant<out T> where T : BaseModel
    {
        T Create();
    }
}
