using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pahest.Models;
using Pahest.Pages.Items;

namespace Pahest.Models
{
    public class PahestContext : DbContext
    {
        public PahestContext (DbContextOptions<PahestContext> options)
            : base(options)
        {
        }
       
        public DbSet<Item> Item { get; set; }
    }
}
