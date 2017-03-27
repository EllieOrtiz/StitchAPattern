using StitchAPattern.StitchingModels;
using System.Data.Entity;

namespace StitchAPattern.StitchingModels
{
    public class StitchAPatternDb : DbContext
    {
        public StitchAPatternDb() : base("name=DefaultConnection")
        {

        }

        public DbSet<BaseStitch> BaseStitches { get; set; }

        
    }
}