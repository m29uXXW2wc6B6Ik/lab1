namespace Stelmashok.Generic.Generic
{
    using Stelmashok.Generic.BaseModels;
    using Stelmashok.Generic.Cov_and_Contr;

    public class ContravariantChildModel : IGenericContravariant<ChildModel>
    {
        public int GetKey(ChildModel t)
        {
            return t.Code + t.Id;
        }
    }
}
