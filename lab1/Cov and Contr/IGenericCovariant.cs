namespace Stelmashok.Generic.Cov_and_Contr
{
    using Stelmashok.Generic.BaseModels;

    public interface IGenericCovariant<out T> where T : BaseModel
    {
        T Create();
    }
}
