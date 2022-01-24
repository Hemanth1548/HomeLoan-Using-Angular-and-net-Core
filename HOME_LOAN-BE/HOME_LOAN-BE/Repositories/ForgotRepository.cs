using HOME_LOAN_BE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Repositories
{
    public class ForgotRepository : IForgot<Customer_Details>
    {
        private readonly loanDB _UserContext;

        public ForgotRepository(loanDB EmpDBContext)
        {
            _UserContext = EmpDBContext;
        }
        public Customer_Details ValidateUser(Customer_Details entity)
        {
            var CurrAdmin = _UserContext.customer_Details.FirstOrDefault
                (Admin => Admin.Propertyid == entity.Propertyid
                 && Admin.Squestion == entity.Squestion && Admin.Answer == entity.Answer);
            return CurrAdmin;
        }
    }
}
