// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContravariantBaseModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ContravariantBaseModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Stelmashok.Generic.Generic
{
    using Stelmashok.Generic.BaseModels;
    using Stelmashok.Generic.Cov_and_Contr;

    public class ContravariantBaseModel : IGenericContravariant<BaseModel>
    {
        public int GetKey(BaseModel baseModel)
        {
            return baseModel.Id;
        }
    }
}
