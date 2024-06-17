using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetTec.Domain.NETFrame.Entities;
using VetTec.Entities;
using VetTec.WindowsForms.Views.Animals;

namespace VetTec.WinForms
{
    public partial class FormList : Form
    {
        private readonly AnimalService _animalService;
        private readonly UserDB _currentUser;

        public FormList(AnimalService animalService, UserDB currentUser)
        {
            InitializeComponent();
            _animalService = animalService;
            _currentUser = currentUser;
            LoadAnimals();
            label1.Text = $"Usuário Conectado: {_currentUser.email}";
        }

        private async Task LoadAnimals()
        {
            var animais = await _animalService.ObterTodosAnimais();
            dataGridView1.DataSource = animais.ToList();
        }

        private void button1_Click(object sender, EventArgs e) // Deletar
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

        private void button2_Click(object sender, EventArgs e) // Editar
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

        private void button3_Click(object sender, EventArgs e) // Adicionar Novo Animal
        {
            var addForm = new AddAnimalForm(_animalService);
            addForm.ShowDialog();
            LoadAnimals();
        }

        private void button4_Click(object sender, EventArgs e) // Deslogar
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Você pode implementar alguma funcionalidade adicional aqui se necessário.
        }
    }
}
