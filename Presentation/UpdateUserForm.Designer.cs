namespace Presentation {
    partial class UpdateUserForm {
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
            DECOR_lbl_id_role = new Label();
            DECOR_lbl_email = new Label();
            txt_role_id = new TextBox();
            txt_email = new TextBox();
            btn_update = new Button();
            DECOR_lbl_editing = new Label();
            DECOR_lbl_username = new Label();
            DECOR_lbl_name = new Label();
            DECOR_lbl_cuit = new Label();
            txt_username = new TextBox();
            txt_name = new TextBox();
            txt_cuit = new TextBox();
            lbl_user_id = new Label();
            SuspendLayout();
            // 
            // DECOR_lbl_id_role
            // 
            DECOR_lbl_id_role.AutoSize = true;
            DECOR_lbl_id_role.Location = new Point(31, 9);
            DECOR_lbl_id_role.Name = "DECOR_lbl_id_role";
            DECOR_lbl_id_role.Size = new Size(40, 15);
            DECOR_lbl_id_role.TabIndex = 1;
            DECOR_lbl_id_role.Text = "IdRole";
            // 
            // DECOR_lbl_email
            // 
            DECOR_lbl_email.AutoSize = true;
            DECOR_lbl_email.Location = new Point(35, 96);
            DECOR_lbl_email.Name = "DECOR_lbl_email";
            DECOR_lbl_email.Size = new Size(36, 15);
            DECOR_lbl_email.TabIndex = 9;
            DECOR_lbl_email.Text = "Email";
            // 
            // txt_role_id
            // 
            txt_role_id.Location = new Point(78, 6);
            txt_role_id.Name = "txt_role_id";
            txt_role_id.Size = new Size(100, 23);
            txt_role_id.TabIndex = 11;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(78, 93);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(100, 23);
            txt_email.TabIndex = 15;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(184, 122);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 17;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += onUpdateButtonClick;
            // 
            // DECOR_lbl_editing
            // 
            DECOR_lbl_editing.AutoSize = true;
            DECOR_lbl_editing.Location = new Point(206, 8);
            DECOR_lbl_editing.Name = "DECOR_lbl_editing";
            DECOR_lbl_editing.Size = new Size(53, 15);
            DECOR_lbl_editing.TabIndex = 18;
            DECOR_lbl_editing.Text = "EDITING:";
            // 
            // DECOR_lbl_username
            // 
            DECOR_lbl_username.AutoSize = true;
            DECOR_lbl_username.Location = new Point(11, 38);
            DECOR_lbl_username.Name = "DECOR_lbl_username";
            DECOR_lbl_username.Size = new Size(60, 15);
            DECOR_lbl_username.TabIndex = 19;
            DECOR_lbl_username.Text = "Username";
            // 
            // DECOR_lbl_name
            // 
            DECOR_lbl_name.AutoSize = true;
            DECOR_lbl_name.Location = new Point(13, 67);
            DECOR_lbl_name.Name = "DECOR_lbl_name";
            DECOR_lbl_name.Size = new Size(59, 15);
            DECOR_lbl_name.TabIndex = 20;
            DECOR_lbl_name.Text = "Full name";
            // 
            // DECOR_lbl_cuit
            // 
            DECOR_lbl_cuit.AutoSize = true;
            DECOR_lbl_cuit.Location = new Point(43, 125);
            DECOR_lbl_cuit.Name = "DECOR_lbl_cuit";
            DECOR_lbl_cuit.Size = new Size(29, 15);
            DECOR_lbl_cuit.TabIndex = 21;
            DECOR_lbl_cuit.Text = "Cuit";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(77, 35);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(100, 23);
            txt_username.TabIndex = 22;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(78, 64);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 23;
            // 
            // txt_cuit
            // 
            txt_cuit.Location = new Point(77, 122);
            txt_cuit.Name = "txt_cuit";
            txt_cuit.Size = new Size(100, 23);
            txt_cuit.TabIndex = 24;
            // 
            // lbl_user_id
            // 
            lbl_user_id.AutoSize = true;
            lbl_user_id.Location = new Point(206, 23);
            lbl_user_id.Name = "lbl_user_id";
            lbl_user_id.Size = new Size(22, 15);
            lbl_user_id.TabIndex = 25;
            lbl_user_id.Text = "---";
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 153);
            Controls.Add(lbl_user_id);
            Controls.Add(txt_cuit);
            Controls.Add(txt_name);
            Controls.Add(txt_username);
            Controls.Add(DECOR_lbl_cuit);
            Controls.Add(DECOR_lbl_name);
            Controls.Add(DECOR_lbl_username);
            Controls.Add(DECOR_lbl_editing);
            Controls.Add(btn_update);
            Controls.Add(txt_email);
            Controls.Add(txt_role_id);
            Controls.Add(DECOR_lbl_email);
            Controls.Add(DECOR_lbl_id_role);
            Name = "UpdateUserForm";
            Text = "UpdateUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label DECOR_lbl_id_role;
        private Label DECOR_lbl_email;
        private TextBox txt_role_id;
        private TextBox txt_last_name;
        private TextBox txt_email;
        private Button btn_update;
        private Label DECOR_lbl_editing;
        private Label DECOR_lbl_username;
        private Label DECOR_lbl_name;
        private Label DECOR_lbl_cuit;
        private TextBox txt_username;
        private TextBox txt_name;
        private TextBox txt_cuit;
        private Label lbl_user_id;
    }
}