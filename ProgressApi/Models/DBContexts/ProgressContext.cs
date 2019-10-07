using System;
using Microsoft.EntityFrameworkCore;

namespace ProgressApi.Models.DBContexts
{
    public class ProgressContext:DbContext
    {
        public ProgressContext(DbContextOptions<ProgressContext> options)                            
            : base(options)  
        {
        }
        public DbSet<PercentProgress> PercentProgress;
        public DbSet<ValuesProgress> ValuesProgress;
    }
}
