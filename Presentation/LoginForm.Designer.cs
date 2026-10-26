namespace Presentation
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btn_login = new Button();
            txt_username = new TextBox();
            txt_password = new TextBox();
            DECOR_lbl_username = new Label();
            DECOR_lbl_password = new Label();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(26, 100);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 0;
            btn_login.Text = "Ingresar";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += attemptLogin;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(12, 27);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(100, 23);
            txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(12, 71);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(100, 23);
            txt_password.TabIndex = 2;
            // 
            // DECOR_lbl_username
            // 
            DECOR_lbl_username.AutoSize = true;
            DECOR_lbl_username.Location = new Point(12, 9);
            DECOR_lbl_username.Name = "DECOR_lbl_username";
            DECOR_lbl_username.Size = new Size(89, 15);
            DECOR_lbl_username.TabIndex = 3;
            DECOR_lbl_username.Text = "Usuario o Email";
            // 
            // DECOR_lbl_password
            // 
            DECOR_lbl_password.AutoSize = true;
            DECOR_lbl_password.Location = new Point(12, 53);
            DECOR_lbl_password.Name = "DECOR_lbl_password";
            DECOR_lbl_password.Size = new Size(67, 15);
            DECOR_lbl_password.TabIndex = 4;
            DECOR_lbl_password.Text = "Contraseña";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(120, 136);
            Controls.Add(DECOR_lbl_password);
            Controls.Add(DECOR_lbl_username);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(btn_login);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label DECOR_lbl_username;
        private Label DECOR_lbl_password;
    }
}
