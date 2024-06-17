using System.ComponentModel;

namespace VetTec.Entities
{
    public class Animal
    {
        public Animal(){}
        public Animal(int id, string name, string species, int age, string description)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Species = species ?? throw new ArgumentNullException(nameof(species));
            Age = age;
            Description = description;
        }

        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; } = "";
        [DisplayName("Especie")]
        public string Species { get; set; } = "";
        [DisplayName("Idade")]

        public int Age { get; set; }
        [DisplayName("Descrição")]
        public string Description { get; set; } = "";
    }
}
