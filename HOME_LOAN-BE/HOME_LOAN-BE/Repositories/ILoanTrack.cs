using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Repositories
{
    public interface ILoanTrack<TEntity>
    {
        TEntity ValidateTrackid(TEntity entity);
    }
}
