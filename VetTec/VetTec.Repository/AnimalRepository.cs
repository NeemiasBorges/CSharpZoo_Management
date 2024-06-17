using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using VetTec.Domain.Interfaces;
using VetTec.Entities;

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
                var cmd = new SqlCommand(" INSERT INTO Animals ( Name ,Specif, Age, RegistrationDate ) VALUES ( @Name, @Specif, @Age, @RegistrationDate )", conn);
                cmd.Parameters.AddWithValue("@Name", animal.Name);
                cmd.Parameters.AddWithValue("@Specif", animal.Species);
                cmd.Parameters.AddWithValue("@Age", animal.Age);
                cmd.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);

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
                         animal.RegistrationDate =  DateTime.Parse((string)reader["RegistrationDate"]);
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
                var cmd = new SqlCommand("SELECT * FROM Animals", conn);
                conn.Open();

                using ( var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        animals.Add(new Animal
                        {
                            Id               = int.Parse((string)reader["Id"]),
                            Name             = (string)reader["Name"],
                            Age              = int.Parse((string)reader["Age"]),
                            Species          = (string)reader["Species"],
                            RegistrationDate = DateTime.Parse((string)reader["RegistrationDate"])
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
                var cmd = new SqlCommand("UPDATE Animals SET Name = @Name, Species = @Species, Age = @Age, RegistrationDate = @RegistrationDate WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", animal.Id);
                cmd.Parameters.AddWithValue("@Name", animal.Name);
                cmd.Parameters.AddWithValue("@Species", animal.Species);
                cmd.Parameters.AddWithValue("@Age", animal.Age);
                cmd.Parameters.AddWithValue("@RegistrationDate", animal.RegistrationDate);

                conn.Open();
                cmd.ExecuteNonQuery();
            }   
        }
    }
}