using Microsoft.Data.SqlClient;
using VetTec.Entities;
using VetTec.Entities.Interfaces;

namespace VetTec.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly string _connectionString;
        public AnimalRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task AddAnimal(Animal animal)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand(" INSERT INTO Animals ( Name ,Species, Age,Description ) VALUES ( @Name, @Species, @Age,@Description )", conn);
                cmd.Parameters.AddWithValue("@Name", animal.Name);
                cmd.Parameters.AddWithValue("@Species", animal.Species);
                cmd.Parameters.AddWithValue("@Age", animal.Age);
                cmd.Parameters.AddWithValue("@Description", animal.Description);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public async Task DeleteAnimal(int id)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("DELETE FROM Animals WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public async Task<Animal> GetAnimalById(int id)
        {
            try
            {
                Animal animal = new Animal();

                using (var conn = new SqlConnection(_connectionString))
                {
                    var cmd = new SqlCommand("SELECT * FROM Animals WHERE Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                         animal.Id               =  int.Parse((string)reader["Id"]);
                         animal.Name             = (string)reader["Name"];
                         animal.Age              =  int.Parse((string)reader["Age"]);
                         animal.Species          = (string)reader["Species"];
                    }

                    return animal;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e.Message);
            }
        }

        public async Task<IEnumerable<Animal>> GetAnimals()
        {
             var animals = new List<Animal>();

            using ( var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("Select Id,Name,Species,Age,COALESCE(Description,'') AS 'Description' From Animals", conn);
                conn.Open();

                using ( var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        animals.Add(new Animal
                        {
                            Id               = (int)reader["Id"],
                            Name             = (string)reader["Name"],
                            Age              = (int)reader["Age"],
                            Species          = (string)reader["Species"],
                            Description      = (string)reader["Description"] ?? "",
                        });
                    }
                }
                return animals;
            }
        }

        public async Task UpdateAnimal(Animal animal)
        {
            using ( var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("UPDATE Animals SET Name = @Name, Description  = @Description, Species = @Species, Age = @Age WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", animal.Id);
                cmd.Parameters.AddWithValue("@Name", animal.Name);
                cmd.Parameters.AddWithValue("@Species", animal.Species);
                cmd.Parameters.AddWithValue("@Age", animal.Age);
                cmd.Parameters.AddWithValue("@Description", animal.Description);

                conn.Open();
                await cmd.ExecuteNonQueryAsync();
            }   
        }
    }
}