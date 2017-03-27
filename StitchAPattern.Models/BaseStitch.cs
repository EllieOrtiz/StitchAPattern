using System.Collections;
using System.Collections.Generic;

namespace StitchAPattern.StitchingModels
{
    public abstract class BaseStitch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public string Pattern { get; set; }
       
       public abstract string CreatePattern();   
        
    }

}