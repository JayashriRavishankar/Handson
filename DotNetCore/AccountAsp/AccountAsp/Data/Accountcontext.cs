using AccountAsp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace AccountAsp.Data
{
    public class Accountcontext : DbContext
    {
        public Accountcontext(DbContextOptions<Accountcontext> options) : base(options)
           
        {
        }

        public DbSet<AccountAsp.Models.Account> Account { get; set; }
    }
}

