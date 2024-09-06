using Libzard_Core.DbObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libzard_Core.Context
{
    public class LibzardDbContext : DbContext
    {
        public LibzardDbContext(DbContextOptions<LibzardDbContext> options)
            : base(options)
        {
        }

        // Add DbSet properties for your entities here
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

    }
}
