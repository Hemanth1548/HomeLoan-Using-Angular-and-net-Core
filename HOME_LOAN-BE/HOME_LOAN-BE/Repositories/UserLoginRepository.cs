using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOME_LOAN_BE.Data;

namespace HOME_LOAN_BE.Repositories
{
    public class UserLoginRepository : IUserLogin<Customer_Details>
    {
        private readonly loanDB _UserContext;

        public UserLoginRepository(loanDB EmpDBContext)
        {
            _UserContext = EmpDBContext;
        }
        public Customer_Details ValidateUser(Customer_Details entity)
        {
            var CurrAdmin = _UserContext.customer_Details.FirstOrDefault
                ( Admin => Admin.Email_id == entity.Email_id
                  && Admin.Password == entity.Password);
            return CurrAdmin;
        }

     
    }
}