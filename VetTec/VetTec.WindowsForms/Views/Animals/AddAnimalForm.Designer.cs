
namespace VetTec.WindowsForms.Views.Animals
{
    partial class AddAnimalForm
    {

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelDescription;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            labelName = new Label();
            labelSpecies = new Label();
            labelAge = new Label();
            labelDescription = new Label();
            numericUpDownAges = new MetroSet_UI.Controls.MetroSetNumeric();
            metroSetDivider1 = new MetroSet_UI.Controls.MetroSetDivider();
            metroSetDivider2 = new MetroSet_UI.Controls.MetroSetDivider();
            buttonSaves = new MetroSet_UI.Controls.MetroSetButton();
            metroSetTile1 = new MetroSet_UI.Controls.MetroSetTile();
            textBoxSpecie = new MetroSet_UI.Controls.MetroSetComboBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(171, 104);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(171, 224);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(200, 27);
            textBoxDescription.TabIndex = 3;
            textBoxDescription.TextChanged += textBoxDescription_TextChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(51, 104);
            labelName.Name = "labelName";
            labelName.Size = new Size(53, 20);
            labelName.TabIndex = 5;
            labelName.Text = "Nome:";
            // 
            // labelSpecies
            // 
            labelSpecies.AutoSize = true;
            labelSpecies.Location = new Point(51, 144);
            labelSpecies.Name = "labelSpecies";
            labelSpecies.Size = new Size(62, 20);
            labelSpecies.TabIndex = 6;
            labelSpecies.Text = "Espécie:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(51, 184);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(50, 20);
            labelAge.TabIndex = 7;
            labelAge.Text = "Idade:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(51, 224);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(77, 20);
            labelDescription.TabIndex = 8;
            labelDescription.Text = "Descrição:";
            // 
            // numericUpDownAges
            // 
            numericUpDownAges.BackColor = Color.Transparent;
            numericUpDownAges.BackgroundColor = Color.Empty;
            numericUpDownAges.BorderColor = Color.FromArgb(150, 150, 150);
            numericUpDownAges.DisabledBackColor = Color.FromArgb(204, 204, 204);
            numericUpDownAges.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            numericUpDownAges.DisabledForeColor = Color.FromArgb(136, 136, 136);
            numericUpDownAges.Font = new Font("Microsoft Sans Serif", 10F);
            numericUpDownAges.IsDerivedStyle = true;
            numericUpDownAges.Location = new Point(171, 184);
            numericUpDownAges.Maximum = 100;
            numericUpDownAges.Minimum = 0;
            numericUpDownAges.Name = "numericUpDownAges";
            numericUpDownAges.Size = new Size(83, 26);
            numericUpDownAges.Style = MetroSet_UI.Enums.Style.Light;
            numericUpDownAges.StyleManager = null;
            numericUpDownAges.SymbolsColor = Color.FromArgb(128, 128, 128);
            numericUpDownAges.TabIndex = 9;
            numericUpDownAges.Text = "metroSetNumeric1";
            numericUpDownAges.ThemeAuthor = "Narwin";
            numericUpDownAges.ThemeName = "MetroLite";
            numericUpDownAges.Value = 0;
            // 
            // metroSetDivider1
            // 
            metroSetDivider1.IsDerivedStyle = true;
            metroSetDivider1.Location = new Point(51, 263);
            metroSetDivider1.Name = "metroSetDivider1";
            metroSetDivider1.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            metroSetDivider1.Size = new Size(320, 4);
            metroSetDivider1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetDivider1.StyleManager = null;
            metroSetDivider1.TabIndex = 10;
            metroSetDivider1.Text = "metroSetDivider1";
            metroSetDivider1.ThemeAuthor = "Narwin";
            metroSetDivider1.ThemeName = "MetroLite";
            metroSetDivider1.Thickness = 1;
            // 
            // metroSetDivider2
            // 
            metroSetDivider2.IsDerivedStyle = true;
            metroSetDivider2.Location = new Point(51, 85);
            metroSetDivider2.Name = "metroSetDivider2";
            metroSetDivider2.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            metroSetDivider2.Size = new Size(320, 4);
            metroSetDivider2.Style = MetroSet_UI.Enums.Style.Light;
            metroSetDivider2.StyleManager = null;
            metroSetDivider2.TabIndex = 11;
            metroSetDivider2.Text = "metroSetDivider2";
            metroSetDivider2.ThemeAuthor = "Narwin";
            metroSetDivider2.ThemeName = "MetroLite";
            metroSetDivider2.Thickness = 1;
            // 
            // buttonSaves
            // 
            buttonSaves.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            buttonSaves.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            buttonSaves.DisabledForeColor = Color.Gray;
            buttonSaves.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonSaves.HoverBorderColor = Color.LightGreen;
            buttonSaves.HoverColor = Color.SeaGreen;
            buttonSaves.HoverTextColor = Color.White;
            buttonSaves.IsDerivedStyle = false;
            buttonSaves.Location = new Point(51, 287);
            buttonSaves.Name = "buttonSaves";
            buttonSaves.NormalBorderColor = Color.Green;
            buttonSaves.NormalColor = Color.ForestGreen;
            buttonSaves.NormalTextColor = Color.White;
            buttonSaves.PressBorderColor = Color.FromArgb(35, 147, 195);
            buttonSaves.PressColor = Color.FromArgb(35, 147, 195);
            buttonSaves.PressTextColor = Color.White;
            buttonSaves.Size = new Size(320, 29);
            buttonSaves.Style = MetroSet_UI.Enums.Style.Light;
            buttonSaves.StyleManager = null;
            buttonSaves.TabIndex = 13;
            buttonSaves.Text = "Salvar";
            buttonSaves.ThemeAuthor = "Narwin";
            buttonSaves.ThemeName = "MetroLite";
            buttonSaves.Click += buttonSaves_Click;
            // 
            // metroSetTile1
            // 
            metroSetTile1.DisabledBackColor = Color.FromArgb(204, 204, 204);
            metroSetTile1.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            metroSetTile1.DisabledForeColor = Color.FromArgb(136, 136, 136);
            metroSetTile1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            metroSetTile1.HoverBorderColor = Color.FromArgb(230, 230, 230);
            metroSetTile1.HoverColor = Color.FromArgb(65, 177, 225);
            metroSetTile1.HoverTextColor = Color.White;
            metroSetTile1.IsDerivedStyle = true;
            metroSetTile1.Location = new Point(51, 36);
            metroSetTile1.Name = "metroSetTile1";
            metroSetTile1.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroSetTile1.NormalColor = Color.FromArgb(65, 177, 225);
            metroSetTile1.NormalTextColor = Color.White;
            metroSetTile1.PressBorderColor = Color.FromArgb(65, 177, 225);
            metroSetTile1.PressColor = Color.FromArgb(65, 177, 225);
            metroSetTile1.PressTextColor = Color.White;
            metroSetTile1.Size = new Size(320, 29);
            metroSetTile1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetTile1.StyleManager = null;
            metroSetTile1.TabIndex = 12;
            metroSetTile1.Text = "                           Adicionar";
            metroSetTile1.ThemeAuthor = "Narwin";
            metroSetTile1.ThemeName = "MetroLite";
            metroSetTile1.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
            metroSetTile1.Click += metroSetTile1_Click;
            // 
            // textBoxSpecie
            // 
            textBoxSpecie.AllowDrop = true;
            textBoxSpecie.ArrowColor = Color.FromArgb(150, 150, 150);
            textBoxSpecie.BackColor = Color.Transparent;
            textBoxSpecie.BackgroundColor = Color.FromArgb(238, 238, 238);
            textBoxSpecie.BorderColor = Color.FromArgb(150, 150, 150);
            textBoxSpecie.CausesValidation = false;
            textBoxSpecie.DisabledBackColor = Color.FromArgb(204, 204, 204);
            textBoxSpecie.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            textBoxSpecie.DisabledForeColor = Color.FromArgb(136, 136, 136);
            textBoxSpecie.DisplayMember = "Macaco";
            textBoxSpecie.DrawMode = DrawMode.OwnerDrawFixed;
            textBoxSpecie.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxSpecie.Font = new Font("Microsoft Sans Serif", 11F);
            textBoxSpecie.FormattingEnabled = true;
            textBoxSpecie.IsDerivedStyle = true;
            textBoxSpecie.ItemHeight = 20;
            textBoxSpecie.Items.AddRange(new object[] { "Cachorro", "Gato", "Coelho", "Cavalo", "Lobo", "Papagaio", "Águia", "Pinguim", "Cobra", "Tartaruga", "Iguana" });
            textBoxSpecie.Location = new Point(171, 152);
            textBoxSpecie.Name = "textBoxSpecie";
            textBoxSpecie.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            textBoxSpecie.SelectedItemForeColor = Color.White;
            textBoxSpecie.Size = new Size(200, 26);
            textBoxSpecie.Style = MetroSet_UI.Enums.Style.Light;
            textBoxSpecie.StyleManager = null;
            textBoxSpecie.TabIndex = 15;
            textBoxSpecie.ThemeAuthor = "Narwin";
            textBoxSpecie.ThemeName = "MetroLite";
            textBoxSpecie.ValueMember = "Macaco";
            textBoxSpecie.SelectedIndexChanged += textBoxSpecie_SelectedIndexChanged;
            // 
            // AddAnimalForm
            // 
            ClientSize = new Size(418, 367);
            Controls.Add(textBoxSpecie);
            Controls.Add(buttonSaves);
            Controls.Add(metroSetTile1);
            Controls.Add(metroSetDivider2);
            Controls.Add(metroSetDivider1);
            Controls.Add(numericUpDownAges);
            Controls.Add(labelDescription);
            Controls.Add(labelAge);
            Controls.Add(labelSpecies);
            Controls.Add(labelName);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Name = "AddAnimalForm";
            Text = "Adicionar Novo Animal";
            ResumeLayout(false);
            PerformLayout();
        }

        private MetroSet_UI.Controls.MetroSetNumeric numericUpDownAges;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider1;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider2;
        private MetroSet_UI.Controls.MetroSetButton buttonSaves;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile1;
        private MetroSet_UI.Controls.MetroSetComboBox textBoxSpecie;
    }
}