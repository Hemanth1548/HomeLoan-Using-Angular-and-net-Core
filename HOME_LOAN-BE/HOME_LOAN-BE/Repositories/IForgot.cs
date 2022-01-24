using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Repositories
{
    public interface IForgot<TEntity>
    {
        TEntity ValidateUser(TEntity entity);
    }
}
