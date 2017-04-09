
namespace StitchAPattern.StitchingModels

{
    public abstract class Pattern
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MyPattern { get; set; }


        public abstract string CreatePattern();  
        
       
        
    }

}