using HOME_LOAN_BE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Repositories
{
    public class PropertyRepository : IDataRepository<Property_Details>
    {
        private readonly loanDB _employeeTrackingDBContext;

        public PropertyRepository(loanDB EmpDBContext)
        {
            _employeeTrackingDBContext = EmpDBContext;
        }
        public void Add(Property_Details entity)
        {
            _employeeTrackingDBContext.property_Details.Add(entity);
            _employeeTrackingDBContext.SaveChanges();
        }

        public void Delete(int entity)
        {
            Property_Details employee = _employeeTrackingDBContext.property_Details.Find(entity);
            _employeeTrackingDBContext.property_Details.Remove(employee);
            _employeeTrackingDBContext.SaveChanges();
        }

        public Property_Details Get(int id)
        {
            return _employeeTrackingDBContext.property_Details.Find(id);
        }

        public IEnumerable<Property_Details> GetAll()
        {
            return _employeeTrackingDBContext.property_Details.ToList();
        }

        public void Update(Property_Details dbEntity, Property_Details entity)
        {
            dbEntity.Propertyid = entity.Propertyid;
            dbEntity.PropertyLocation = entity.PropertyLocation;
            dbEntity.PropertyName = entity.PropertyName;
            dbEntity.EstimatedAmount = entity.EstimatedAmount;
           // dbEntity.Customer_id = entity.Customer_id;
          
            _employeeTrackingDBContext.SaveChanges();
        }



    }
}
