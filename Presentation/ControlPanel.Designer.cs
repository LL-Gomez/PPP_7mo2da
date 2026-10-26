namespace Presentation {
    partial class ControlPanel {
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
            dgv_main = new DataGridView();
            btn_create = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_next_page = new Button();
            btn_previous_page = new Button();
            txt_page = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_main).BeginInit();
            SuspendLayout();
            // 
            // dgv_main
            // 
            dgv_main.AllowUserToAddRows = false;
            dgv_main.AllowUserToDeleteRows = false;
            dgv_main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_main.Location = new Point(12, 12);
            dgv_main.MultiSelect = false;
            dgv_main.Name = "dgv_main";
            dgv_main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_main.Size = new Size(921, 360);
            dgv_main.TabIndex = 0;
            dgv_main.CellEnter += onRowSelectUpdate;
            // 
            // btn_create
            // 
            btn_create.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_create.Location = new Point(12, 378);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(91, 60);
            btn_create.TabIndex = 1;
            btn_create.Text = "Crear usuario";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += onCreateButtonPress;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(109, 378);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(91, 60);
            btn_update.TabIndex = 2;
            btn_update.Text = "Modificar usuario";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += onUpdateButtonPress;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(206, 378);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(91, 60);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Borrar usuario";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += onDeleteButtonPress;
            // 
            // btn_next_page
            // 
            btn_next_page.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_next_page.Location = new Point(842, 378);
            btn_next_page.Name = "btn_next_page";
            btn_next_page.Size = new Size(91, 60);
            btn_next_page.TabIndex = 4;
            btn_next_page.Text = "Siguiente pagina";
            btn_next_page.UseVisualStyleBackColor = true;
            btn_next_page.Click += increasePageCount;
            // 
            // btn_previous_page
            // 
            btn_previous_page.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_previous_page.Location = new Point(745, 378);
            btn_previous_page.Name = "btn_previous_page";
            btn_previous_page.Size = new Size(91, 60);
            btn_previous_page.TabIndex = 5;
            btn_previous_page.Text = "Anterior pagina";
            btn_previous_page.UseVisualStyleBackColor = true;
            btn_previous_page.Click += decreasePageCount;
            // 
            // txt_page
            // 
            txt_page.Location = new Point(703, 399);
            txt_page.Name = "txt_page";
            txt_page.Size = new Size(36, 23);
            txt_page.TabIndex = 6;
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 450);
            Controls.Add(txt_page);
            Controls.Add(btn_previous_page);
            Controls.Add(btn_next_page);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_create);
            Controls.Add(dgv_main);
            Name = "ControlPanel";
            Text = "ControlPanel";
            ((System.ComponentModel.ISupportInitialize)dgv_main).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_main;
        private Button btn_create;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_next_page;
        private Button btn_previous_page;
        private TextBox txt_page;
    }
}