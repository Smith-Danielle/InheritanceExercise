using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }

        public bool LivesInWater { get; set; }
        public int ShedPerYear { get; set; }
        public string ScalePattern { get; set; }
        public int NumberOfTeeth { get; set; }
        
    }
}
