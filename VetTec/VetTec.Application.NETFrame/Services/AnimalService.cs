using Serilog;
using VetTec.Entities;
using VetTec.Entities.Interfaces;

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
            _logger.Information($"Animal : {animal.Name} - {animal.Species} adicionado com sucesso: por: adm@adm.com às {DateTime.Now}");
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
            _logger.Information($"Animal : {animal.Name} - {animal.Species} atualizado com sucesso: por: adm@adm.com às {DateTime.Now}");
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
            _logger.Information($"Animal : {id} Removido com sucesso: por: adm@adm.com às {DateTime.Now}");
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
            _logger.Information($"Todos os animais obtidos com sucesso às {DateTime.Now}");
            return animais;
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Erro ao obter todos os animais");
            throw;
        }
    }
}
