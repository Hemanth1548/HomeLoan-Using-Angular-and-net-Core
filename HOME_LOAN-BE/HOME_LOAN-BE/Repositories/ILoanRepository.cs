using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Repositories
{
    public interface ILoanRepository<TEntity>
    {


        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        //  TEntity Validate(TEntity entity);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(int entity);
    }
}
