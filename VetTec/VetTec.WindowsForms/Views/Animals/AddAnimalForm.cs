using VetTec.Entities;

namespace VetTec.WindowsForms.Views.Animals
{
    public partial class AddAnimalForm : Form
    {
        private AnimalService _animalService;
        public AddAnimalForm(AnimalService animalService)
        {
            _animalService = animalService;
            InitializeComponent();
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
                Name = textBoxName.Text,
                Species = textBoxSpecies.Text,
                Age = (int)numericUpDownAge.Value,
                Description = textBoxDescription.Text
            };
            _animalService.AdicionarAnimal(newAnimal);

            this.Close();
        }

        private void textBoxSpecies_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
