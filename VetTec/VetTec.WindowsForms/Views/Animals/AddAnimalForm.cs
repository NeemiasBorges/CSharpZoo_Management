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

        private void metroSetTile1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSpecie_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonSaves_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
               string.IsNullOrWhiteSpace(textBoxSpecie.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }
            var newAnimal = new Animal
            {
                Name = textBoxName.Text,
                Species = textBoxSpecie.Text,
                Age = (int)numericUpDownAges.Value,
                Description = textBoxDescription.Text
            };
            _animalService.AdicionarAnimal(newAnimal);

            this.Close();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
