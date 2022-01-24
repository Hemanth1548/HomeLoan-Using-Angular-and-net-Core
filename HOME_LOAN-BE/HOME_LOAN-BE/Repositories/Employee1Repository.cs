
using HOME_LOAN_BE.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HOME_LOAN_BE
{
    public class Employee1Repository : IDataRepository<Employee_Details>
    {
        private readonly loanDB _employeeTrackingDBContext;

        public Employee1Repository(loanDB EmpDBContext)
        {
            _employeeTrackingDBContext = EmpDBContext;
        }
        public void Add(Employee_Details entity)
        {
            _employeeTrackingDBContext.employee_Details.Add(entity);
            _employeeTrackingDBContext.SaveChanges();
        }

        public void Delete(int entity)
        {
            Employee_Details employee = _employeeTrackingDBContext.employee_Details.Find(entity);
            _employeeTrackingDBContext.employee_Details.Remove(employee);
            _employeeTrackingDBContext.SaveChanges();
        }

        public Employee_Details Get(int Propertyid)
        {
            return _employeeTrackingDBContext.employee_Details.FirstOrDefault(b => b.Propertyid == Propertyid);
        }

        public IEnumerable<Employee_Details> GetAll()
        {
            return _employeeTrackingDBContext.employee_Details.ToList();
        }

        public void Update(Employee_Details dbEntity, Employee_Details entity)
        {
            dbEntity.Type_of_Employment = entity.Type_of_Employment;
            dbEntity.Retirement_Age = entity.Retirement_Age;
            dbEntity.Organisation_Type = entity.Organisation_Type;
            dbEntity.Employee_Name = entity.Employee_Name;
            dbEntity.Propertyid = entity.Propertyid;
           

            _employeeTrackingDBContext.SaveChanges();
        }

       

        //public Employee Validate(Employee entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
