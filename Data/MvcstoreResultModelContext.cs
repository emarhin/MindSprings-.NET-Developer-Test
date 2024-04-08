using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MindSpringsTest.Models;

namespace MvcstoreResultModel.Data
{
    public class MvcstoreResultModelContext : DbContext
    {
        public MvcstoreResultModelContext (DbContextOptions<MvcstoreResultModelContext> options)
            : base(options)
        {
        }

        public DbSet<MindSpringsTest.Models.storeResultModel> storeResultModel { get; set; } = default!;
    }
}
