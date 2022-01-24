using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE { 

    public interface IDataAdmin<TEntity>
    {
       
        TEntity ValidateAdmin(TEntity entity);
        void Add(TEntity entity);

    }
}
