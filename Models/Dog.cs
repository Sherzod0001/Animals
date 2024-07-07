using System;

namespace Animals.Models
{
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: \"bark\" ");
        }
    }
}
