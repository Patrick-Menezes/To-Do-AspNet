using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using To_do_AspNet.Models;

namespace To_do_AspNet.Data
{
    public class To_do_AspNetContext : DbContext
    {
        public To_do_AspNetContext (DbContextOptions<To_do_AspNetContext> options)
            : base(options)
        {
        }

        public DbSet<To_do_AspNet.Models.Activity> Activity { get; set; } = default!;
    }
}
