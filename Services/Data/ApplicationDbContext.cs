﻿using EmployeesWeb.Models;
using Microsoft.EntityFrameworkCore;


namespace EmployeesWeb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {   
            
        }
        public DbSet<Employee> employees { get; set; }
    }
}
