using Microsoft.EntityFrameworkCore;
using RecentAreaDemo.Areas.SuperAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecentAreaDemo.Areas.SuperAdmin.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
