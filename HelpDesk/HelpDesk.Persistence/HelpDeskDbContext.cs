using HelpDesk.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Persistence
{
    class HelpDeskDbContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
    }
}
