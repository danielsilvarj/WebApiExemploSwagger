using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiExemploSwagger.Models;

namespace WebApiExemploSwagger.Data
{
    public class WebApiExemploSwaggerContext : DbContext
    {
        public WebApiExemploSwaggerContext (DbContextOptions<WebApiExemploSwaggerContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiExemploSwagger.Models.Cliente> Cliente { get; set; }
    }
}
