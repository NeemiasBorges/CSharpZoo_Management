using System;

namespace VetTec.Entities
{
    public class Animal
    {
        public Animal(){}
        public Animal(int id, string name, string species, int age, DateTime? registration)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Species = species ?? throw new ArgumentNullException(nameof(species));
            Age = age;
            RegistrationDate = registration;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public DateTime? RegistrationDate { get; set; }
    }
}
