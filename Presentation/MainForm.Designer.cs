namespace Presentation
{
    partial class MainForm
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
        private void InitializeComponent() {
            DECOR_lbl_username = new Label();
            lbl_username = new Label();
            lbl_email = new Label();
            DECOR_lbl_email = new Label();
            lbl_creationdate = new Label();
            DECOR_lbl_creationdate = new Label();
            lbl_name = new Label();
            DECOR_lbl_name = new Label();
            btn_change_password = new Button();
            btn_change_questions = new Button();
            btn_control_panel = new Button();
            SuspendLayout();
            // 
            // DECOR_lbl_username
            // 
            DECOR_lbl_username.AutoSize = true;
            DECOR_lbl_username.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DECOR_lbl_username.Location = new Point(12, 9);
            DECOR_lbl_username.Name = "DECOR_lbl_username";
            DECOR_lbl_username.Size = new Size(63, 20);
            DECOR_lbl_username.TabIndex = 0;
            DECOR_lbl_username.Text = "Usuario";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(12, 29);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(22, 15);
            lbl_username.TabIndex = 1;
            lbl_username.Text = "---";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(12, 64);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(22, 15);
            lbl_email.TabIndex = 3;
            lbl_email.Text = "---";
            // 
            // DECOR_lbl_email
            // 
            DECOR_lbl_email.AutoSize = true;
            DECOR_lbl_email.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DECOR_lbl_email.Location = new Point(12, 44);
            DECOR_lbl_email.Name = "DECOR_lbl_email";
            DECOR_lbl_email.Size = new Size(137, 20);
            DECOR_lbl_email.TabIndex = 2;
            DECOR_lbl_email.Text = "Correo electronico";
            // 
            // lbl_creationdate
            // 
            lbl_creationdate.AutoSize = true;
            lbl_creationdate.Location = new Point(218, 64);
            lbl_creationdate.Name = "lbl_creationdate";
            lbl_creationdate.Size = new Size(22, 15);
            lbl_creationdate.TabIndex = 7;
            lbl_creationdate.Text = "---";
            // 
            // DECOR_lbl_creationdate
            // 
            DECOR_lbl_creationdate.AutoSize = true;
            DECOR_lbl_creationdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DECOR_lbl_creationdate.Location = new Point(218, 44);
            DECOR_lbl_creationdate.Name = "DECOR_lbl_creationdate";
            DECOR_lbl_creationdate.Size = new Size(132, 20);
            DECOR_lbl_creationdate.TabIndex = 6;
            DECOR_lbl_creationdate.Text = "Fecha de creacion";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(218, 29);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(22, 15);
            lbl_name.TabIndex = 9;
            lbl_name.Text = "---";
            // 
            // DECOR_lbl_name
            // 
            DECOR_lbl_name.AutoSize = true;
            DECOR_lbl_name.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DECOR_lbl_name.Location = new Point(218, 9);
            DECOR_lbl_name.Name = "DECOR_lbl_name";
            DECOR_lbl_name.Size = new Size(67, 20);
            DECOR_lbl_name.TabIndex = 8;
            DECOR_lbl_name.Text = "Nombre";
            // 
            // btn_change_password
            // 
            btn_change_password.Location = new Point(12, 82);
            btn_change_password.Name = "btn_change_password";
            btn_change_password.Size = new Size(75, 39);
            btn_change_password.TabIndex = 10;
            btn_change_password.Text = "Cambiar contraseña";
            btn_change_password.UseVisualStyleBackColor = true;
            // 
            // btn_change_questions
            // 
            btn_change_questions.Location = new Point(93, 82);
            btn_change_questions.Name = "btn_change_questions";
            btn_change_questions.Size = new Size(117, 39);
            btn_change_questions.TabIndex = 11;
            btn_change_questions.Text = "Cambiar preguntas de seguridad";
            btn_change_questions.UseVisualStyleBackColor = true;
            btn_change_questions.Click += btn_change_questions_Click;
            // 
            // btn_control_panel
            // 
            btn_control_panel.Location = new Point(287, 82);
            btn_control_panel.Name = "btn_control_panel";
            btn_control_panel.Size = new Size(75, 39);
            btn_control_panel.TabIndex = 12;
            btn_control_panel.Text = "Panel de control";
            btn_control_panel.UseVisualStyleBackColor = true;
            btn_control_panel.Click += btn_control_panel_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 129);
            Controls.Add(btn_control_panel);
            Controls.Add(btn_change_questions);
            Controls.Add(btn_change_password);
            Controls.Add(lbl_name);
            Controls.Add(DECOR_lbl_name);
            Controls.Add(lbl_creationdate);
            Controls.Add(DECOR_lbl_creationdate);
            Controls.Add(lbl_email);
            Controls.Add(DECOR_lbl_email);
            Controls.Add(lbl_username);
            Controls.Add(DECOR_lbl_username);
            Name = "MainForm";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DECOR_lbl_username;
        private Label lbl_username;
        private Label lbl_email;
        private Label DECOR_lbl_email;
        private Label lbl_creationdate;
        private Label DECOR_lbl_creationdate;
        private Label lbl_name;
        private Label DECOR_lbl_name;
        private Button btn_change_password;
        private Button btn_change_questions;
        private Button btn_control_panel;
    }
}