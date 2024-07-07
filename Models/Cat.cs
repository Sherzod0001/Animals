using System;

namespace Animals.Models
{
    public  class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: \"meow\" ");
        }
    }
}
