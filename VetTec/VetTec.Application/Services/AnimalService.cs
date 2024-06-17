using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VetTec.Domain.Interfaces;
using VetTec.Entities;

namespace VetTec.Application
{
    public class AnimalService
    {
        private readonly IAnimalRepository _animalRepository;
        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }
        public async Task AddAnimal(Animal animal)
        {
            try
            {
                await _animalRepository.AddAnimal(animal);
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task DeleteAnimal(int id)
        {
            try
            {
                await _animalRepository.DeleteAnimal(id);
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<Animal> GetAnimalById(int id)
        {
            try
            {
                return await _animalRepository.GetAnimalById(id);
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<IEnumerable<Animal>> GetAnimals()
        {
            try
            {
                return await _animalRepository.GetAnimals();
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task UpdateAnimal(Animal animal)
        {
            try
            {
                await _animalRepository.UpdateAnimal(animal);
            }
            catch (System.Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
