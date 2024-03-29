﻿using System.Reflection.Metadata.Ecma335;

namespace DogsMvc.Models
{
	public class DataService
	{
		private List<Dog> dogs = new List<Dog>()
		{
			new Dog()
			{
				Id = 301,
				Name = "Siberian Husky",
				Age = 4
			},
			new Dog()
			{
				Id = 196,
				Name = "Poodle",
				Age = 2
			},
            new Dog()
            {
                Id = 51,
                Name = "German Shepherd",
                Age = 8
            }
        };


		public void AddDog(Dog newDog)
		{
			dogs.Add(newDog);
		}

		public Dog GetDogById(int id) => dogs.SingleOrDefault(d => d.Id == id);

		public Dog[] GetAllDogs() => dogs.ToArray();

        public void RemoveDog(Dog dogToRemove)
        {
            dogs.Remove(dogToRemove);
        }
        //a method that takes out the dogs prop and replaces it with the new information.
    }
}
