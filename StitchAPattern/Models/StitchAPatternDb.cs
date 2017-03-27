using StitchAPattern.StitchingModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StitchAPattern.Models
{
    public class StitchAPatternDb : DbContext
    {
        public DbSet<Pattern> Patterns { get; set; }
    }
}