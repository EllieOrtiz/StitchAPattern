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
            var p = new StitchingModels.SquareStitch
            {
                Name = "Plum City",
                Description = "Doodle beads, seed beads and sequins.",

            };

            Console.WriteLine(p.MyPattern);
          
            context.Patterns.AddOrUpdate(s => s.Name, p);
        }
    }
}
