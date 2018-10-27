using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyNetCoreMVC.Models
{
    public class MyNetCoreMVCContext : DbContext
    {
        public MyNetCoreMVCContext (DbContextOptions<MyNetCoreMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MyNetCoreMVC.Models.Product> Product { get; set; }
    }
}
