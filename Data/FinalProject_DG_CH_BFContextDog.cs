using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject_DG_CH_BF.Models;

namespace FinalProject_DG_CH_BF.Data
{
    public class FinalProject_DG_CH_BFContextDog : DbContext
    {
        public FinalProject_DG_CH_BFContextDog (DbContextOptions<FinalProject_DG_CH_BFContextDog> options)
            : base(options)
        {
        }

        public DbSet<FinalProject_DG_CH_BF.Models.Dog> Dog { get; set; } = default!;
    }
}
