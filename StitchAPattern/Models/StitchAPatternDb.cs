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
        public StitchAPatternDb() : base("name=DefaultConnection")
        {

        }

        public DbSet<Pattern> Patterns { get; set; }

        public System.Data.Entity.DbSet<StitchAPattern.StitchingModels.SquareStitch> SquareStitches { get; set; }
    }
}