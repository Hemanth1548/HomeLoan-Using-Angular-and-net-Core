
using HOME_LOAN_BE.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HOME_LOAN_BE
{
    public class CustomerRepository : IDataRepository<Customer_Details>
    {
        private readonly loanDB _customerTrackingDBContext;

        public CustomerRepository(loanDB EmpDBContext)
        {
            _customerTrackingDBContext = EmpDBContext;
        }
        public void Add(Customer_Details entity)
        {
            _customerTrackingDBContext.customer_Details.Add(entity);
            _customerTrackingDBContext.SaveChanges();
        }

        public void Delete(int entity)
        {
            Customer_Details employee = _customerTrackingDBContext.customer_Details.Find(entity);
            _customerTrackingDBContext.customer_Details.Remove(employee);
            _customerTrackingDBContext.SaveChanges();
        }

        public Customer_Details Get(int Propertyid)
        {
            return _customerTrackingDBContext.customer_Details.FirstOrDefault(b => b.Propertyid == Propertyid);
        }

        public IEnumerable<Customer_Details> GetAll()
        {
            return _customerTrackingDBContext.customer_Details.ToList();
        }

        public void Update(Customer_Details dbEntity, Customer_Details entity)
        {
            //dbEntity.Customer_id = entity.Customer_id;
            dbEntity.First_Name = entity.First_Name;
            dbEntity.Middle_Name = entity.Middle_Name;
            dbEntity.Last_Name = entity.Last_Name;
            dbEntity.Email_id = entity.Email_id;
            dbEntity.Password = entity.Password;
            dbEntity.Confirm_Password = entity.Confirm_Password;
            dbEntity.Phone_No = entity.Phone_No;
            dbEntity.DOB = entity.DOB;
            dbEntity.Gender = entity.Gender;
            dbEntity.Nationality = entity.Nationality;
            dbEntity.Aadhar_No = entity.Aadhar_No;
            dbEntity.Pan_No = entity.Pan_No;
            dbEntity.Propertyid = entity.Propertyid;
            dbEntity.Squestion = entity.Squestion;
            dbEntity.Answer = entity.Answer;
            _customerTrackingDBContext.SaveChanges();
        }

       

        //public Employee Validate(Employee entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
