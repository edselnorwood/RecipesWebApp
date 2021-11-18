using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipesWebApp.Models;

namespace RecipesWebApp.Data
{
    public class RecipesWebAppContext : DbContext
    {
        public RecipesWebAppContext (DbContextOptions<RecipesWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<RecipesWebApp.Models.Recipes> Recipes { get; set; }
    }
}
