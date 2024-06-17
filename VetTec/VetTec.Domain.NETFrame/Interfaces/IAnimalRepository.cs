using VetTec.Entities;

namespace VetTec.Entities.Interfaces
{
    public interface IAnimalRepository
    {
        public Task<IEnumerable<Animal>> GetAnimals();
        public Task<Animal> GetAnimalById(int id);
        public Task AddAnimal(Animal animal);
        public Task UpdateAnimal(Animal animal);
        public Task DeleteAnimal(int id);
    }
}
