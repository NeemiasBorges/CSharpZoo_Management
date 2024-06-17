using System;
using System.Collections.Generic;
using VetTec.Entities.Interfaces;
using VetTec.Entities;
using Serilog;

public class AnimalService
{
    private readonly IAnimalRepository _animalRepository;
    private readonly ILogger _logger;

    public AnimalService(IAnimalRepository animalRepository, ILogger logger)
    {
        _animalRepository = animalRepository;
        _logger = logger;
    }

    public async Task AdicionarAnimal(Animal animal)
    {
        try
        {
            await _animalRepository.AddAnimal(animal);
            _logger.Information("Animal adicionado com sucesso: {Animal}", animal);
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Erro ao adicionar animal: {Animal}", animal);
            throw;
        }
    }

    public async Task AtualizarAnimal(Animal animal)
    {
        try
        {
            await _animalRepository.UpdateAnimal(animal);
            _logger.Information("Animal atualizado com sucesso: {Animal}", animal);
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Erro ao atualizar animal: {Animal}", animal);
            throw;
        }
    }

    public async Task RemoverAnimal(int id)
    {
        try
        {
            _animalRepository.DeleteAnimal(id);
            _logger.Information("Animal removido com sucesso: {Id}", id);
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Erro ao remover animal: {Id}", id);
            throw;
        }
    }

    public async Task<Animal> ObterAnimalPorId(int id)
    {
        try
        {
            var animal = await _animalRepository.GetAnimalById(id);
            _logger.Information("Animal obtido por ID com sucesso: {Animal}", animal);
            return animal;
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Erro ao obter animal por ID: {Id}", id);
            throw;
        }
    }

    public async Task<IEnumerable<Animal>> ObterTodosAnimais()
    {
        try
        {
            var animais = await _animalRepository.GetAnimals();
            _logger.Information("Todos os animais obtidos com sucesso");
            return animais;
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Erro ao obter todos os animais");
            throw;
        }
    }
}
