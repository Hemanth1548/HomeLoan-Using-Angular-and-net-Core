
using HOME_LOAN_BE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HOME_LOAN_BE.Data
{
    public class loanDB : DbContext
    {
        public loanDB(DbContextOptions<loanDB> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Admin_Details> admin_Details { get; set; }
        public DbSet<Customer_Details> customer_Details { get; set; }
        public DbSet<Employee_Details> employee_Details { get; set; }
        public DbSet<Loan> loan { get; set; }
        public DbSet<Property_Details> property_Details { get; set; }
       public DbSet<Status_details> status_Details{ get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee_Details>()
        //        .HasKey(e => new { e.Emp_ID, e.Property_id });
        //    modelBuilder.Entity<Customer_Details>()
        //        .HasKey(e => new { e.Customer_id, e.Property_id });
        //    modelBuilder.Entity<Loan>()
        //        .HasKey(e => new { e.Loan_id, e.Property_ID });

        //}
    }
}
