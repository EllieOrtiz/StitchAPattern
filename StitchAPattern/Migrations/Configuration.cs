namespace StitchAPattern.Migrations
{
    using StitchAPattern.StitchingModels;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<StitchAPattern.StitchingModels.StitchAPatternDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StitchAPattern.StitchingModels.StitchAPatternDb context)
        {
            context.BaseStitches.AddOrUpdate(s => s.Name,
                new SquareStitch
                {
                    Name = "Horizon",
                    Body = "Gold sequin embroidery",
                    Pattern = "--  --  --  -- -- -- -- -- --"}
                   
                );
             
        }
    }
}
