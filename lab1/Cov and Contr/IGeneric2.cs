using lab1.Base;

namespace lab1.Cov_and_Contr
{
    public interface IGeneric2<out T> where T : BaseModel
    {
        T Create();
    }
}
