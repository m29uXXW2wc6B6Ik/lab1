﻿
namespace Stelmashok.Generic.Cov_and_Contr
{
    using Stelmashok.Generic.BaseModels;

    public interface IGenericContravariant<in T> where T : BaseModel
    {
        int GetKey(T t);
    }
}
