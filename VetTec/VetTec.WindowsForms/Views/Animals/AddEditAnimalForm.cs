using VetTec.Entities;

namespace VetTec.WindowsForms.Views.Animals
{
    public partial class AddEditAnimalForm : Form
    {
        private Animal animal;
        private AnimalService _animalService;

        public AddEditAnimalForm(Animal animal, AnimalService animalService)
        {
            this.animal = animal;
            _animalService = animalService;
            InitializeComponent(animal);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxSpecies.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }
            var newAnimal = new Animal
            {
                Id = animal.Id,
                Name = textBoxName.Text,
                Species = textBoxSpecies.Text,
                Age = (int)numericUpDownAge.Value,
                Description = textBoxDescription.Text
            };
            _animalService.AtualizarAnimal(newAnimal);

            this.Close();
        }
    }
}
