using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.TypeConfig
{
    public static class Extension
    {
        public static void ConfigureAllTypeConfig(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ActivityTypeConfig());
        }
    }
}