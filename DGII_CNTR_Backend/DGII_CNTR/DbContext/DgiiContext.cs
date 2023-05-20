using DGII_CNTR.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DGII_CNTR.ContextDB
{
    public class DgiiDbContext : DbContext
    {

        public DgiiDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ComprobantesFiscales> comprobantesF { get; set; }

        public DbSet<Contribuyentes> Contribuyente { get; set; }

    }
}
