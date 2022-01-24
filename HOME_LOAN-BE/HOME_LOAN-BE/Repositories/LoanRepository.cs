using HOME_LOAN_BE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Repositories
{
    public class LoanRepository : ILoanRepository<Loan>
    {
        private readonly loanDB _employeeTrackingDBContext;

        public LoanRepository(loanDB EmpDBContext)
        {
            _employeeTrackingDBContext = EmpDBContext;
        }
        public void Add(Loan entity)
        {
            _employeeTrackingDBContext.loan.Add(entity);
            _employeeTrackingDBContext.SaveChanges();
        }

        public void Delete(int entity)
        {
            Loan employee = _employeeTrackingDBContext.loan.Find(entity);
            _employeeTrackingDBContext.loan.Remove(employee);
            _employeeTrackingDBContext.SaveChanges();
        }

        public Loan Get(int Propertyid)
        {
            // _employeeTrackingDBContext.loan.Find(id);
            return _employeeTrackingDBContext.loan.FirstOrDefault(b => b.Propertyid == Propertyid);
        }

        public IEnumerable<Loan> GetAll()
        {
            return _employeeTrackingDBContext.loan.ToList();
        }

        public void Update(Loan dbEntity, Loan entity)
        {
            dbEntity.Loan_id = entity.Loan_id;
            dbEntity.Max_Loan_Amt = entity.Max_Loan_Amt;
            dbEntity.ROI = entity.ROI;
            dbEntity.Tenure = entity.Tenure;
            dbEntity.Loan_Amt = entity.Loan_Amt;
            dbEntity.Propertyid = entity.Propertyid;
           // dbEntity.Emp_ID = entity.Emp_ID;
            //dbEntity.Customer_id = entity.Customer_id;
            _employeeTrackingDBContext.SaveChanges();
        }



    }
}
