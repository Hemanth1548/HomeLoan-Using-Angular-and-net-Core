using HOME_LOAN_BE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Repositories
{
    public class LoanTrackerRepository : ILoanTrack<Customer_Details>
    {
        private readonly loanDB _UserContext;

        public LoanTrackerRepository(loanDB EmpDBContext)
        {
            _UserContext = EmpDBContext;
        }
        public Customer_Details ValidateTrackid(Customer_Details entity)
        {
            var CurrAdmin = _UserContext.customer_Details.FirstOrDefault
                (Admin => Admin.Propertyid == entity.Propertyid
                 && Admin.Phone_No == entity.Phone_No && Admin.DOB == entity.DOB);
            return CurrAdmin;
        }
    }
    }
