using HOME_LOAN_BE.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HOME_LOAN_BE
{
    public class AdminRepository : IDataAdmin<Admin_Details>
    {
        private readonly loanDB _AdminDBContext;

        public AdminRepository(loanDB EmpDBContext)
        {
            _AdminDBContext = EmpDBContext;
        }
        public void Add(Admin_Details entity)
        {
            _AdminDBContext.admin_Details.Add(entity);
            _AdminDBContext.SaveChanges();
        }

       
        public Admin_Details ValidateAdmin(Admin_Details entity)
        {
            var CurrAdmin = _AdminDBContext.admin_Details.FirstOrDefault
                (
                  Admin => Admin.AdminUsername == entity.AdminUsername
                  && Admin.Password == entity.Password);


            return CurrAdmin;
        }

    }
}
