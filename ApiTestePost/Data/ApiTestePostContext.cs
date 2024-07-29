using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiTestePost.Models;

namespace ApiTestePost.Data
{
    public class ApiTestePostContext : DbContext
    {
        public ApiTestePostContext (DbContextOptions<ApiTestePostContext> options)
            : base(options)
        {
        }

        public DbSet<ApiTestePost.Models.Produto> Produto { get; set; }
    }
}
