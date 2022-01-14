using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace crm.Models
{
    public class CurrencyDB : DbContext
    {
        public CurrencyDB(DbContextOptions<CurrencyDB> options) : base(options)
        {

        }

        public DbSet<Currency> Currency { get; set; }
    }
}
