using VetTec.Application.NETFrame.Services;
using VetTec.WinForms;

namespace VetTec.WindowsForms.Views.User
{
    public partial class LoginUserForm : Form
    {
        private AnimalService _animalService;
        private UserService _userService;

        public LoginUserForm(AnimalService animalService, Application.NETFrame.Services.UserService userService)
        { 
            _animalService = animalService;
            _userService = userService;
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(user_txt.Text))
            {
                MessageBox.Show("Por favor, preencha o email.");
                return;
            }

            if (string.IsNullOrWhiteSpace(senha_txt.Text))
            {
                MessageBox.Show("Por favor, preencha a senha.");
                return;
            }

            var logged = _userService.Login(user_txt.Text.ToString(), senha_txt.Text.ToString());

            if (logged)
            {
                var formList = new FormList(_animalService, _userService);
                formList.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
        }

        private void user_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void senha_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
