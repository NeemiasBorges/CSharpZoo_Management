using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetTec.Application.NETFrame.Services;
using VetTec.Domain.NETFrame.Entities;
using VetTec.Entities;
using VetTec.WindowsForms.Views.Animals;

namespace VetTec.WinForms
{
    public partial class FormList : Form
    {
        private readonly AnimalService _animalService;
        private readonly UserService _userService;

        public FormList(AnimalService animalService, UserService userService)
        {
            InitializeComponent();
            _animalService = animalService;
            _userService = userService;
            LoadAnimals();
        }

        private async Task LoadAnimals()
        {
            var animais = await _animalService.ObterTodosAnimais();
            dataGridView1.DataSource = animais.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroSet_Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var animal = (Animal)dataGridView1.SelectedRows[0].DataBoundItem;
                _animalService.RemoverAnimal(animal.Id);
                LoadAnimals();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um animal para deletar.");
            }
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var animal = (Animal)dataGridView1.SelectedRows[0].DataBoundItem;
                var editForm = new AddEditAnimalForm(animal, _animalService);
                editForm.ShowDialog();
                LoadAnimals();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um animal para editar.");
            }
        }

        private void metroSetButton1_Click_1(object sender, EventArgs e)
        {
            var addForm = new AddAnimalForm(_animalService);
            addForm.ShowDialog();
            LoadAnimals();
        }

        private void metroSetLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dlga_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroSetBadge1_Click(object sender, EventArgs e)
        {

        }
    }
}
