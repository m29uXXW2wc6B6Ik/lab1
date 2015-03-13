namespace Stelmashok.Generic.Generic
{
    using Stelmashok.Generic.BaseModels;
    using Stelmashok.Generic.Cov_and_Contr;

    public class CovariantChildModel : IGenericCovariant<ChildModel>
    {
        public ChildModel Create()
        {
            return new ChildModel();
        }
    }
}
