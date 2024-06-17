namespace VetTec.WinForms
{
    partial class FormList
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            metroSet_Btn_Delete = new MetroSet_UI.Controls.MetroSetButton();
            edt_btn = new MetroSet_UI.Controls.MetroSetButton();
            btn_AddNEW = new MetroSet_UI.Controls.MetroSetButton();
            dlga_btn = new MetroSet_UI.Controls.MetroSetButton();
            metroSetDivider1 = new MetroSet_UI.Controls.MetroSetDivider();
            metroSetDivider2 = new MetroSet_UI.Controls.MetroSetDivider();
            metroSetBadge1 = new MetroSet_UI.Controls.MetroSetBadge();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.GridColor = SystemColors.MenuHighlight;
            dataGridView1.Location = new Point(75, 114);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView1.Size = new Size(675, 260);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // metroSet_Btn_Delete
            // 
            metroSet_Btn_Delete.Cursor = Cursors.Hand;
            metroSet_Btn_Delete.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroSet_Btn_Delete.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroSet_Btn_Delete.DisabledForeColor = Color.Gray;
            metroSet_Btn_Delete.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            metroSet_Btn_Delete.HoverBorderColor = Color.LightCoral;
            metroSet_Btn_Delete.HoverColor = Color.FromArgb(255, 128, 128);
            metroSet_Btn_Delete.HoverTextColor = Color.White;
            metroSet_Btn_Delete.IsDerivedStyle = false;
            metroSet_Btn_Delete.Location = new Point(640, 411);
            metroSet_Btn_Delete.Name = "metroSet_Btn_Delete";
            metroSet_Btn_Delete.NormalBorderColor = Color.FromArgb(255, 128, 128);
            metroSet_Btn_Delete.NormalColor = Color.IndianRed;
            metroSet_Btn_Delete.NormalTextColor = Color.White;
            metroSet_Btn_Delete.PressBorderColor = Color.FromArgb(192, 64, 0);
            metroSet_Btn_Delete.PressColor = Color.FromArgb(255, 128, 128);
            metroSet_Btn_Delete.PressTextColor = Color.White;
            metroSet_Btn_Delete.Size = new Size(110, 29);
            metroSet_Btn_Delete.Style = MetroSet_UI.Enums.Style.Light;
            metroSet_Btn_Delete.StyleManager = null;
            metroSet_Btn_Delete.TabIndex = 6;
            metroSet_Btn_Delete.Text = "Deletar";
            metroSet_Btn_Delete.ThemeAuthor = "Narwin";
            metroSet_Btn_Delete.ThemeName = "MetroLite";
            metroSet_Btn_Delete.Click += metroSet_Btn_Delete_Click;
            // 
            // edt_btn
            // 
            edt_btn.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            edt_btn.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            edt_btn.DisabledForeColor = Color.Gray;
            edt_btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            edt_btn.HoverBorderColor = Color.FromArgb(95, 207, 255);
            edt_btn.HoverColor = Color.FromArgb(95, 207, 255);
            edt_btn.HoverTextColor = Color.White;
            edt_btn.IsDerivedStyle = true;
            edt_btn.Location = new Point(516, 411);
            edt_btn.Name = "edt_btn";
            edt_btn.NormalBorderColor = Color.FromArgb(65, 177, 225);
            edt_btn.NormalColor = Color.FromArgb(65, 177, 225);
            edt_btn.NormalTextColor = Color.White;
            edt_btn.PressBorderColor = Color.FromArgb(35, 147, 195);
            edt_btn.PressColor = Color.FromArgb(35, 147, 195);
            edt_btn.PressTextColor = Color.White;
            edt_btn.Size = new Size(94, 29);
            edt_btn.Style = MetroSet_UI.Enums.Style.Light;
            edt_btn.StyleManager = null;
            edt_btn.TabIndex = 8;
            edt_btn.Text = "Editar";
            edt_btn.ThemeAuthor = "Narwin";
            edt_btn.ThemeName = "MetroLite";
            edt_btn.Click += metroSetButton1_Click;
            // 
            // btn_AddNEW
            // 
            btn_AddNEW.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btn_AddNEW.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btn_AddNEW.DisabledForeColor = Color.Gray;
            btn_AddNEW.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btn_AddNEW.HoverBorderColor = Color.FromArgb(128, 255, 128);
            btn_AddNEW.HoverColor = Color.FromArgb(128, 255, 128);
            btn_AddNEW.HoverTextColor = Color.White;
            btn_AddNEW.IsDerivedStyle = false;
            btn_AddNEW.Location = new Point(281, 411);
            btn_AddNEW.Name = "btn_AddNEW";
            btn_AddNEW.NormalBorderColor = Color.ForestGreen;
            btn_AddNEW.NormalColor = Color.LightGreen;
            btn_AddNEW.NormalTextColor = Color.White;
            btn_AddNEW.PressBorderColor = Color.FromArgb(35, 147, 195);
            btn_AddNEW.PressColor = Color.FromArgb(35, 147, 195);
            btn_AddNEW.PressTextColor = Color.White;
            btn_AddNEW.Size = new Size(209, 29);
            btn_AddNEW.Style = MetroSet_UI.Enums.Style.Light;
            btn_AddNEW.StyleManager = null;
            btn_AddNEW.TabIndex = 9;
            btn_AddNEW.Text = "Adicionar Novo Animal";
            btn_AddNEW.ThemeAuthor = "Narwin";
            btn_AddNEW.ThemeName = "MetroLite";
            btn_AddNEW.Click += metroSetButton1_Click_1;
            // 
            // dlga_btn
            // 
            dlga_btn.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            dlga_btn.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            dlga_btn.DisabledForeColor = Color.Gray;
            dlga_btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            dlga_btn.HoverBorderColor = Color.FromArgb(255, 128, 128);
            dlga_btn.HoverColor = Color.FromArgb(255, 128, 128);
            dlga_btn.HoverTextColor = Color.White;
            dlga_btn.IsDerivedStyle = false;
            dlga_btn.Location = new Point(75, 492);
            dlga_btn.Name = "dlga_btn";
            dlga_btn.NormalBorderColor = Color.IndianRed;
            dlga_btn.NormalColor = Color.Tomato;
            dlga_btn.NormalTextColor = Color.White;
            dlga_btn.PressBorderColor = Color.FromArgb(35, 147, 195);
            dlga_btn.PressColor = Color.FromArgb(35, 147, 195);
            dlga_btn.PressTextColor = Color.White;
            dlga_btn.Size = new Size(94, 29);
            dlga_btn.Style = MetroSet_UI.Enums.Style.Light;
            dlga_btn.StyleManager = null;
            dlga_btn.TabIndex = 11;
            dlga_btn.Text = "Deslogar";
            dlga_btn.ThemeAuthor = "Narwin";
            dlga_btn.ThemeName = "MetroLite";
            dlga_btn.Click += dlga_btn_Click;
            // 
            // metroSetDivider1
            // 
            metroSetDivider1.IsDerivedStyle = true;
            metroSetDivider1.Location = new Point(75, 89);
            metroSetDivider1.Name = "metroSetDivider1";
            metroSetDivider1.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            metroSetDivider1.Size = new Size(675, 4);
            metroSetDivider1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetDivider1.StyleManager = null;
            metroSetDivider1.TabIndex = 12;
            metroSetDivider1.Text = "metroSetDivider1";
            metroSetDivider1.ThemeAuthor = "Narwin";
            metroSetDivider1.ThemeName = "MetroLite";
            metroSetDivider1.Thickness = 1;
            // 
            // metroSetDivider2
            // 
            metroSetDivider2.IsDerivedStyle = true;
            metroSetDivider2.Location = new Point(75, 391);
            metroSetDivider2.Name = "metroSetDivider2";
            metroSetDivider2.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            metroSetDivider2.Size = new Size(675, 4);
            metroSetDivider2.Style = MetroSet_UI.Enums.Style.Light;
            metroSetDivider2.StyleManager = null;
            metroSetDivider2.TabIndex = 13;
            metroSetDivider2.Text = "metroSetDivider2";
            metroSetDivider2.ThemeAuthor = "Narwin";
            metroSetDivider2.ThemeName = "MetroLite";
            metroSetDivider2.Thickness = 1;
            // 
            // metroSetBadge1
            // 
            metroSetBadge1.BackColor = Color.Transparent;
            metroSetBadge1.BadgeAlignment = MetroSet_UI.Enums.BadgeAlign.TopRight;
            metroSetBadge1.BadgeText = "3";
            metroSetBadge1.DisabledBackColor = Color.FromArgb(204, 204, 204);
            metroSetBadge1.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            metroSetBadge1.DisabledForeColor = Color.FromArgb(136, 136, 136);
            metroSetBadge1.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetBadge1.HoverBadgeColor = Color.FromArgb(85, 187, 245);
            metroSetBadge1.HoverBadgeTextColor = Color.White;
            metroSetBadge1.HoverBorderColor = Color.FromArgb(102, 102, 102);
            metroSetBadge1.HoverColor = Color.FromArgb(102, 102, 102);
            metroSetBadge1.HoverTextColor = Color.White;
            metroSetBadge1.IsDerivedStyle = true;
            metroSetBadge1.Location = new Point(529, 37);
            metroSetBadge1.Name = "metroSetBadge1";
            metroSetBadge1.NormalBadgeColor = Color.FromArgb(65, 177, 225);
            metroSetBadge1.NormalBadgeTextColor = Color.White;
            metroSetBadge1.NormalBorderColor = Color.FromArgb(204, 204, 204);
            metroSetBadge1.NormalColor = Color.FromArgb(238, 238, 238);
            metroSetBadge1.NormalTextColor = Color.Black;
            metroSetBadge1.PressBadgeColor = Color.FromArgb(45, 147, 205);
            metroSetBadge1.PressBadgeTextColor = Color.White;
            metroSetBadge1.PressBorderColor = Color.FromArgb(51, 51, 51);
            metroSetBadge1.PressColor = Color.FromArgb(51, 51, 51);
            metroSetBadge1.PressTextColor = Color.White;
            metroSetBadge1.Size = new Size(166, 46);
            metroSetBadge1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetBadge1.StyleManager = null;
            metroSetBadge1.TabIndex = 14;
            metroSetBadge1.Text = "adm@adm.com";
            metroSetBadge1.ThemeAuthor = "Narwin";
            metroSetBadge1.ThemeName = "MetroLite";
            metroSetBadge1.Click += metroSetBadge1_Click;
            // 
            // FormList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(metroSetBadge1);
            Controls.Add(metroSetDivider2);
            Controls.Add(metroSetDivider1);
            Controls.Add(dlga_btn);
            Controls.Add(btn_AddNEW);
            Controls.Add(edt_btn);
            Controls.Add(metroSet_Btn_Delete);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormList";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroSet_UI.Controls.MetroSetButton metroSet_Btn_Delete;
        private MetroSet_UI.Controls.MetroSetButton edt_btn;
        private MetroSet_UI.Controls.MetroSetButton btn_AddNEW;
        private MetroSet_UI.Controls.MetroSetButton dlga_btn;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider1;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider2;
        private MetroSet_UI.Controls.MetroSetBadge metroSetBadge1;
    }
}

