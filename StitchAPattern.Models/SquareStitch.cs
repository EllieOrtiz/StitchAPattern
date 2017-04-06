using System;
using System.Text;
using System.Threading;



namespace StitchAPattern.StitchingModels
{
    public class SquareStitch : Pattern
    {
        public SquareStitch()
        {
            this.MyPattern = this.CreatePattern();
        }

        public override string CreatePattern()
        {
            Thread.Sleep(1);
            Random randNum = new Random();
            int randElem = randNum.Next(0, 1001);
            StringBuilder sb = new StringBuilder();

            //generates a random line
            for (int lines = 0; lines < 20; lines++)
            {
                //generates 20 random lines
                for (int i = 0; i < 20; i++)
                {
                    randElem = randNum.Next(0, 1001);

                    if (randElem % 2 == 0 && randElem < 500)
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