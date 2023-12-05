using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcPicoPublish.Models;

namespace MvcPicoPublish.Data
{
    public class MvcPicoPublishContext : DbContext
    {
        public MvcPicoPublishContext (DbContextOptions<MvcPicoPublishContext> options)
            : base(options)
        {
        }

        public DbSet<MvcPicoPublish.Models.Product> Product { get; set; } = default!;
    }
}
