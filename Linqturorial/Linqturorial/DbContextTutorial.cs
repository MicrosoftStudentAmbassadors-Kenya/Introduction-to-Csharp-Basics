using System;
using System.Collections.Generic;

using System.Text;
using Microsoft.EntityFrameworkCore;


namespace Linqturorial
{
  public  class DbContextTutorial:DbContext
    {
        public DbContextTutorial(DbContextOptions<DbContextTutorial> conne):base(conne)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
