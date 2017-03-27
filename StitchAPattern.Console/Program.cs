using StitchAPattern.StitchingModels;

namespace StitchAPattern.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var poop = new PoopPattern();
            var poop2 = new PoopPattern();
            var square = new SquareStitch();

            var models = new BaseStitch[] { poop, poop2, square };
            for (int i = 0; i < models.Length; i++)
            {
                System.Console.WriteLine(models[i].CreatePattern());
            }

            System.Console.ReadLine();
        }
    }
}
