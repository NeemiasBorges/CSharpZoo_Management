namespace VetTec.WindowsForms.Views.User
{
    partial class LoginUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            metroSetDivider1 = new MetroSet_UI.Controls.MetroSetDivider();
            metroSetDivider2 = new MetroSet_UI.Controls.MetroSetDivider();
            login_btn = new MetroSet_UI.Controls.MetroSetButton();
            metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            user_txt = new TextBox();
            senha_txt = new TextBox();
            SuspendLayout();
            // 
            // metroSetDivider1
            // 
            metroSetDivider1.IsDerivedStyle = true;
            metroSetDivider1.Location = new Point(31, 67);
            metroSetDivider1.Name = "metroSetDivider1";
            metroSetDivider1.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            metroSetDivider1.Size = new Size(344, 4);
            metroSetDivider1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetDivider1.StyleManager = null;
            metroSetDivider1.TabIndex = 0;
            metroSetDivider1.Text = "metroSetDivider1";
            metroSetDivider1.ThemeAuthor = "Narwin";
            metroSetDivider1.ThemeName = "MetroLite";
            metroSetDivider1.Thickness = 1;
            // 
            // metroSetDivider2
            // 
            metroSetDivider2.IsDerivedStyle = true;
            metroSetDivider2.Location = new Point(30, 262);
            metroSetDivider2.Name = "metroSetDivider2";
            metroSetDivider2.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            metroSetDivider2.Size = new Size(344, 4);
            metroSetDivider2.Style = MetroSet_UI.Enums.Style.Light;
            metroSetDivider2.StyleManager = null;
            metroSetDivider2.TabIndex = 1;
            metroSetDivider2.Text = "metroSetDivider2";
            metroSetDivider2.ThemeAuthor = "Narwin";
            metroSetDivider2.ThemeName = "MetroLite";
            metroSetDivider2.Thickness = 1;
            // 
            // login_btn
            // 
            login_btn.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            login_btn.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            login_btn.DisabledForeColor = Color.Gray;
            login_btn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            login_btn.HoverBorderColor = Color.FromArgb(128, 255, 128);
            login_btn.HoverColor = Color.FromArgb(128, 255, 128);
            login_btn.HoverTextColor = Color.White;
            login_btn.IsDerivedStyle = false;
            login_btn.Location = new Point(30, 285);
            login_btn.Name = "login_btn";
            login_btn.NormalBorderColor = Color.SeaGreen;
            login_btn.NormalColor = Color.MediumSeaGreen;
            login_btn.NormalTextColor = Color.White;
            login_btn.PressBorderColor = Color.FromArgb(35, 147, 195);
            login_btn.PressColor = Color.FromArgb(35, 147, 195);
            login_btn.PressTextColor = Color.White;
            login_btn.Size = new Size(343, 29);
            login_btn.Style = MetroSet_UI.Enums.Style.Light;
            login_btn.StyleManager = null;
            login_btn.TabIndex = 2;
            login_btn.Text = "Acessar";
            login_btn.ThemeAuthor = "Narwin";
            login_btn.ThemeName = "MetroLite";
            login_btn.Click += this.login_btn_Click;
            // 
            // metroSetLabel1
            // 
            metroSetLabel1.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel1.IsDerivedStyle = true;
            metroSetLabel1.Location = new Point(36, 81);
            metroSetLabel1.Name = "metroSetLabel1";
            metroSetLabel1.Size = new Size(125, 29);
            metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel1.StyleManager = null;
            metroSetLabel1.TabIndex = 3;
            metroSetLabel1.Text = "Usuario:";
            metroSetLabel1.ThemeAuthor = "Narwin";
            metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            metroSetLabel2.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel2.IsDerivedStyle = true;
            metroSetLabel2.Location = new Point(36, 154);
            metroSetLabel2.Name = "metroSetLabel2";
            metroSetLabel2.Size = new Size(125, 29);
            metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel2.StyleManager = null;
            metroSetLabel2.TabIndex = 4;
            metroSetLabel2.Text = "Senha:";
            metroSetLabel2.ThemeAuthor = "Narwin";
            metroSetLabel2.ThemeName = "MetroLite";
            // 
            // user_txt
            // 
            user_txt.Location = new Point(31, 113);
            user_txt.Name = "user_txt";
            user_txt.Size = new Size(337, 27);
            user_txt.TabIndex = 1;
            user_txt.TextChanged += user_txt_TextChanged;
            // 
            // senha_txt
            // 
            senha_txt.Location = new Point(31, 203);
            senha_txt.Name = "senha_txt";
            senha_txt.Size = new Size(337, 27);
            senha_txt.TabIndex = 0;
            senha_txt.TextChanged += senha_txt_TextChanged;
            // 
            // LoginUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 345);
            Controls.Add(senha_txt);
            Controls.Add(user_txt);
            Controls.Add(metroSetLabel2);
            Controls.Add(metroSetLabel1);
            Controls.Add(login_btn);
            Controls.Add(metroSetDivider2);
            Controls.Add(metroSetDivider1);
            Name = "LoginUserForm";
            Text = "LoginUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider1;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider2;
        private MetroSet_UI.Controls.MetroSetButton login_btn;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private TextBox user_txt;
        private TextBox senha_txt;
    }
}