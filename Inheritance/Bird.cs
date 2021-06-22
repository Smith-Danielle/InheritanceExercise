using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
        }

        public int Wingspan { get; set; }
        public string BeakColor { get; set; }
        public bool LivesInNest { get; set; }
        public bool AbilityToFly { get; set; }
    }
}
