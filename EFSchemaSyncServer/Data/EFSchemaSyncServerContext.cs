using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFSchemaSyncServer.Models
{
    public class EFSchemaSyncServerContext : DbContext
    {
        public EFSchemaSyncServerContext (DbContextOptions<EFSchemaSyncServerContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<SDDataTable> SDDataTables { get; set; }
        public DbSet<SDColumn> SDColumns { get; set; }
        public DbSet<SDComboboxColumn> SDComboboxColumns { get; set; }
        public DbSet<SDTextBoxColumn> SDTextBoxColumns { get; set; }
        public DbSet<SDProject> SDProjects { get; set; }
    }
}
