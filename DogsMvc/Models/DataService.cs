using System.Reflection.Metadata.Ecma335;

namespace DogsMvc.Models
{
    public class DataService
    {
        List<Dog> dogs = new List<Dog>();

        public Dog[] AddDog(Dog dog)
        {
            dogs.Add(dog);
            return dogs.ToArray();
        }

        public Dog[] GetAllDogs()
        {
            return dogs.ToArray();
        }

        public Dog GetDogById(int id)
        {
            var d = dogs
                .First(o => o.Id == id);
            return d;
        }
    }
}
