using System;

namespace Animals.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }

        public virtual void Speak() // bu metodning virtual bo'lganligining sababi har xil hayvonlar har xil ovoz chiqaradi 
        {
            Console.WriteLine($"{Name} makes sound");
        }

    }
}
