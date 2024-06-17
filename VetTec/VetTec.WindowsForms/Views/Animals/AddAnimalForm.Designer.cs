
namespace VetTec.WindowsForms.Views.Animals
{
    partial class AddAnimalForm
    {

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSpecies;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonSave;
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
            textBoxSpecies = new TextBox();
            numericUpDownAge = new NumericUpDown();
            textBoxDescription = new TextBox();
            buttonSave = new Button();
            labelName = new Label();
            labelSpecies = new Label();
            labelAge = new Label();
            labelDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(150, 30);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxSpecies
            // 
            textBoxSpecies.Location = new Point(150, 70);
            textBoxSpecies.Name = "textBoxSpecies";
            textBoxSpecies.Size = new Size(200, 27);
            textBoxSpecies.TabIndex = 1;
            textBoxSpecies.TextChanged += textBoxSpecies_TextChanged;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(150, 110);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(200, 27);
            numericUpDownAge.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(150, 150);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(200, 27);
            textBoxDescription.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(150, 190);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(200, 30);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Salvar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(30, 30);
            labelName.Name = "labelName";
            labelName.Size = new Size(53, 20);
            labelName.TabIndex = 5;
            labelName.Text = "Nome:";
            // 
            // labelSpecies
            // 
            labelSpecies.AutoSize = true;
            labelSpecies.Location = new Point(30, 70);
            labelSpecies.Name = "labelSpecies";
            labelSpecies.Size = new Size(62, 20);
            labelSpecies.TabIndex = 6;
            labelSpecies.Text = "Espécie:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(30, 110);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(50, 20);
            labelAge.TabIndex = 7;
            labelAge.Text = "Idade:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(30, 150);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(77, 20);
            labelDescription.TabIndex = 8;
            labelDescription.Text = "Descrição:";
            // 
            // AddAnimalForm
            // 
            ClientSize = new Size(400, 250);
            Controls.Add(labelDescription);
            Controls.Add(labelAge);
            Controls.Add(labelSpecies);
            Controls.Add(labelName);
            Controls.Add(buttonSave);
            Controls.Add(textBoxDescription);
            Controls.Add(numericUpDownAge);
            Controls.Add(textBoxSpecies);
            Controls.Add(textBoxName);
            Name = "AddAnimalForm";
            Text = "Adicionar Novo Animal";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}