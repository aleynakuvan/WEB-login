using Odev1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Odev1.Data
{
    
        public class ProjectContext : DbContext
        {
            public ProjectContext() : base("Server=MSI\\SQLEXPRESS; Database=WebOdev;integrated security=True;") 
            {
            }
            public DbSet<User> Users { get; set; }
        }
    
}
