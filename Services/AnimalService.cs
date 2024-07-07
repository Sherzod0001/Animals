using Animals.Models;
using System;

namespace Animals.Services
{
    internal class AnimalService()
    {
        public void FeedAnimal(Dog dog)
        {
            dog.Eat();
        }

        public void SleepAnimal(Dog dog)
        {
            dog.Sleep();
        }

        public void SpeakAnimal(Dog dog)
        {
            dog.Speak();
        }
        public void FeedAnimal(Cat cat)
        {
            cat.Eat();
        }

        public void SleepAnimal(Cat cat)
        {
            cat.Sleep();
        }

        public void SpeakAnimal(Cat cat)
        {
            cat.Speak();
        }
    }
}
