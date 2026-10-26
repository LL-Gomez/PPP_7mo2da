namespace Presentation {
    partial class CreateUserForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            txt_cuit = new TextBox();
            txt_name = new TextBox();
            txt_username = new TextBox();
            DECOR_lbl_cuit = new Label();
            DECOR_lbl_name = new Label();
            DECOR_lbl_username = new Label();
            btn_update = new Button();
            txt_email = new TextBox();
            txt_role_id = new TextBox();
            DECOR_lbl_email = new Label();
            DECOR_lbl_id_role = new Label();
            SuspendLayout();
            // 
            // txt_cuit
            // 
            txt_cuit.Location = new Point(78, 120);
            txt_cuit.Name = "txt_cuit";
            txt_cuit.Size = new Size(100, 23);
            txt_cuit.TabIndex = 37;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(79, 62);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 36;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(78, 33);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(100, 23);
            txt_username.TabIndex = 35;
            // 
            // DECOR_lbl_cuit
            // 
            DECOR_lbl_cuit.AutoSize = true;
            DECOR_lbl_cuit.Location = new Point(44, 123);
            DECOR_lbl_cuit.Name = "DECOR_lbl_cuit";
            DECOR_lbl_cuit.Size = new Size(29, 15);
            DECOR_lbl_cuit.TabIndex = 34;
            DECOR_lbl_cuit.Text = "Cuit";
            // 
            // DECOR_lbl_name
            // 
            DECOR_lbl_name.AutoSize = true;
            DECOR_lbl_name.Location = new Point(22, 65);
            DECOR_lbl_name.Name = "DECOR_lbl_name";
            DECOR_lbl_name.Size = new Size(51, 15);
            DECOR_lbl_name.TabIndex = 33;
            DECOR_lbl_name.Text = "Nombre";
            // 
            // DECOR_lbl_username
            // 
            DECOR_lbl_username.AutoSize = true;
            DECOR_lbl_username.Location = new Point(25, 36);
            DECOR_lbl_username.Name = "DECOR_lbl_username";
            DECOR_lbl_username.Size = new Size(47, 15);
            DECOR_lbl_username.TabIndex = 32;
            DECOR_lbl_username.Text = "Usuario";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(185, 120);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 30;
            btn_update.Text = "Crear";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(79, 91);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(100, 23);
            txt_email.TabIndex = 29;
            // 
            // txt_role_id
            // 
            txt_role_id.Location = new Point(79, 4);
            txt_role_id.Name = "txt_role_id";
            txt_role_id.Size = new Size(100, 23);
            txt_role_id.TabIndex = 28;
            // 
            // DECOR_lbl_email
            // 
            DECOR_lbl_email.AutoSize = true;
            DECOR_lbl_email.Location = new Point(36, 94);
            DECOR_lbl_email.Name = "DECOR_lbl_email";
            DECOR_lbl_email.Size = new Size(36, 15);
            DECOR_lbl_email.TabIndex = 27;
            DECOR_lbl_email.Text = "Email";
            // 
            // DECOR_lbl_id_role
            // 
            DECOR_lbl_id_role.AutoSize = true;
            DECOR_lbl_id_role.Location = new Point(20, 7);
            DECOR_lbl_id_role.Name = "DECOR_lbl_id_role";
            DECOR_lbl_id_role.Size = new Size(53, 15);
            DECOR_lbl_id_role.TabIndex = 26;
            DECOR_lbl_id_role.Text = "Id de Rol";
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 152);
            Controls.Add(txt_cuit);
            Controls.Add(txt_name);
            Controls.Add(txt_username);
            Controls.Add(DECOR_lbl_cuit);
            Controls.Add(DECOR_lbl_name);
            Controls.Add(DECOR_lbl_username);
            Controls.Add(btn_update);
            Controls.Add(txt_email);
            Controls.Add(txt_role_id);
            Controls.Add(DECOR_lbl_email);
            Controls.Add(DECOR_lbl_id_role);
            Name = "CreateUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_cuit;
        private TextBox txt_name;
        private TextBox txt_username;
        private Label DECOR_lbl_cuit;
        private Label DECOR_lbl_name;
        private Label DECOR_lbl_username;
        private Button btn_update;
        private TextBox txt_email;
        private TextBox txt_role_id;
        private Label DECOR_lbl_email;
        private Label DECOR_lbl_id_role;
    }
}