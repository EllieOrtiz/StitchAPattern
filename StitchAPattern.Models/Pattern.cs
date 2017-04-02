
namespace StitchAPattern.StitchingModels

{
    public abstract class Pattern
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        
       
        public abstract string CreatePattern();   
        
    }

}