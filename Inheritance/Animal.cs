using System;
namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {
            
        }
        public string Color { get; set; }
        public double Weight { get; set; }
        public string Mobility { get; set; }
        public int LifeSpan { get; set; }
        public string Sound { get; set; }

        public void MakesNoise()
        {
            Console.WriteLine($"This animal likes to {Sound}.");
        }
    }
}
