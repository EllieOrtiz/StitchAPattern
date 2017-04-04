namespace StitchAPattern.Migrations
{
    using StitchingModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StitchAPattern.Models.StitchAPatternDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "StitchAPattern.Models.StitchAPatternDb";
        }

        protected override void Seed(StitchAPattern.Models.StitchAPatternDb context)
        {
            context.Patterns.AddOrUpdate(s => s.Name,
                new StitchingModels.SquareStitch
                {
                    Name = "Plum City",
                    Body = "Doodle beads, seed beads and sequins.",
                   
                });
        }
    }
}
