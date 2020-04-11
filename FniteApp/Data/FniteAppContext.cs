using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FniteApp.Models;

namespace FniteApp.Data
{
    public class FniteAppContext : DbContext
    {
        public FniteAppContext (DbContextOptions<FniteAppContext> options) : base(options)
        {

        }

        public DbSet<Weapon> Weapon { get; set; }
    }
}
