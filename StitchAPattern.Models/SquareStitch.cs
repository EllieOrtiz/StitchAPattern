using System;
using System.Text;
using System.Threading;
using System.Collections.Generic;



namespace StitchAPattern.StitchingModels
{
    public class SquareStitch : Pattern
    {
        public override string CreatePattern()
        {
            Thread.Sleep(1);
            var randNum = new Random();
            var randElem = randNum.Next(0, 1001);
            var sb = new StringBuilder();

            //generates a random line
            for (int lines = 0; lines < 20; lines++)
            {
                //generates 20 random lines
                for (int i = 0; i < 20; i++)
                {
                    randElem = randNum.Next(0, 1001);

                    if (randElem % 2 == 0)
                    {                      
                        sb.Append("--"); // Appending to StringBuilder.
                    }
                    else
                    {                       
                        sb.Append("  ");
                    }
                }
                
                sb.Append("\n");
            }

            return sb.ToString();
 
        }

    }
}