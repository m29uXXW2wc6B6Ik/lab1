using lab1.Base;
using lab1.Cov_and_Contr;

namespace lab1.Generic
{
   public class Generic12:IGeneric1<ChildModel>
    {
        public int GetKey(ChildModel t)
        {
            return t.Code + t.Id;
        }
    }
}
