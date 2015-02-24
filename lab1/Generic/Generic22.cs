using lab1.Base;
using lab1.Cov_and_Contr;

namespace lab1.Generic
{
    public class Generic22:IGeneric2<ChildModel>
    {
        public ChildModel Create()
        {
            return new ChildModel();
        }
    }
}
