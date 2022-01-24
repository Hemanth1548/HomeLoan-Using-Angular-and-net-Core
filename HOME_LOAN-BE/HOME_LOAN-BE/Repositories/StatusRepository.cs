using HOME_LOAN_BE.Data;
using HOME_LOAN_BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Repositories
{
    public class StatusRepository : IDataRepository<Status_details>
    {
        private readonly loanDB _statusTrackingDBContext;

        public StatusRepository(loanDB EmpDBContext)
        {
            _statusTrackingDBContext = EmpDBContext;
        }
        public void Add(Status_details entity)
        {
            _statusTrackingDBContext.status_Details.Add(entity);
            _statusTrackingDBContext.SaveChanges();
        }

        public void Delete(int entity)
        {
            Status_details status = _statusTrackingDBContext.status_Details.Find(entity);
            _statusTrackingDBContext.status_Details.Remove(status);
            _statusTrackingDBContext.SaveChanges();
        }

        public Status_details Get(int Propertyid)
        {
            return _statusTrackingDBContext.status_Details.FirstOrDefault(b => b.Propertyid == Propertyid);
        }

        public IEnumerable<Status_details> GetAll()
        {
            return _statusTrackingDBContext.status_Details.ToList();
        }

        public void Update(Status_details dbEntity, Status_details entity)
        {
            dbEntity.statusid = entity.statusid;
            //dbEntity.accno = entity.accno;
            dbEntity.amount = entity.amount;
            dbEntity.status = entity.status;
             dbEntity.Propertyid = entity.Propertyid;

            _statusTrackingDBContext.SaveChanges();
        }



    }
}
