using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetTec.WinForms
{
    public partial class FormList : Form
    {
        private readonly AnimalService _animalService;
        public FormList(AnimalService animalService)
        {
            InitializeComponent();
             LoadAnimals();
            _animalService = animalService ?? throw new ArgumentNullException(nameof(animalService));
        }

        private async Task LoadAnimals()
        {
            var animals = _animalService.GetAnimals();
            dataGridView1.DataSource = animals.ToList();
        }

        private async Task button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var animal = (Animal)dataGridView1.SelectedRows[0].DataBoundItem;
                var editForm = new AddEditAnimalForm(animal, _animalService);
                editForm.ShowDialog();
                await LoadAnimals();
            }
        }

        private async Task button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var animal = (Animal)dataGridView1.SelectedRows[0].DataBoundItem;
                _animalService.DeleteAnimal(animal.Id);
                await LoadAnimals();
            }
        }
    }
}
