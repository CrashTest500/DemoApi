using DemoApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoApi
{
    public class DogStore
    {
        private static List<Dog> dogs = new()
        {
            new Dog()
            {
                Id = 1,
                Name = "Ollie",
                Breed = "Golden Retriever"
            },
            new Dog()
            {
                Id = 2,
                Name = "Tucker",
                Breed = "Chocolate Lab"
            },
            new Dog()
            {
                Id = 3,
                Name = "Abby",
                Breed = "French Bulldog"
            }
        };

        public Dog Get(int i)
        {
            return dogs.SingleOrDefault(d => d.Id == i);
        }

        public List<Dog> Get()
        {
            return dogs;
        }
    }
}
