using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceCRUD.Models
{
    public class ResturantDbContext:DbContext
    {
        public ResturantDbContext(DbContextOptions<ResturantDbContext> options):base(options)

        {

        }
        public DbSet<Customer> Customers { get; set; }
    }


}
