namespace Presentation {
    partial class DeleteUserForm {
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
            txt_user_id = new TextBox();
            DECOR_lbl_user_id = new Label();
            btn_delete = new Button();
            SuspendLayout();
            // 
            // txt_user_id
            // 
            txt_user_id.Location = new Point(12, 27);
            txt_user_id.Name = "txt_user_id";
            txt_user_id.Size = new Size(96, 23);
            txt_user_id.TabIndex = 0;
            // 
            // DECOR_lbl_user_id
            // 
            DECOR_lbl_user_id.AutoSize = true;
            DECOR_lbl_user_id.Location = new Point(12, 9);
            DECOR_lbl_user_id.Name = "DECOR_lbl_user_id";
            DECOR_lbl_user_id.Size = new Size(75, 15);
            DECOR_lbl_user_id.TabIndex = 1;
            DECOR_lbl_user_id.Text = "Id de usuario";
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(12, 60);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(96, 23);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Borrar usuario";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += onDeleteButtonClick;
            // 
            // DeleteUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(120, 95);
            Controls.Add(btn_delete);
            Controls.Add(DECOR_lbl_user_id);
            Controls.Add(txt_user_id);
            Name = "DeleteUserForm";
            Text = "DeleteUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_user_id;
        private Label DECOR_lbl_user_id;
        private Button btn_delete;
    }
}