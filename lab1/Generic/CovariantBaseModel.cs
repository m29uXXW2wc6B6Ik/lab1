namespace Stelmashok.Generic.Generic
{
    using Stelmashok.Generic.BaseModels;
    using Stelmashok.Generic.Cov_and_Contr;

    public class CovariantBaseModel : IGenericCovariant<BaseModel>
    {
        public BaseModel Create()
        {
            return new BaseModel();
        }
    }
}
