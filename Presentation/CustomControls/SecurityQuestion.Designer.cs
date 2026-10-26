namespace Presentation.CustomControls {
    partial class SecurityQuestion {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            gb_question = new GroupBox();
            DECOR_lbl_question = new Label();
            txt_answer = new TextBox();
            txt_question = new TextBox();
            DECOR_lbl_answer = new Label();
            gb_question.SuspendLayout();
            SuspendLayout();
            // 
            // gb_question
            // 
            gb_question.Controls.Add(DECOR_lbl_question);
            gb_question.Controls.Add(txt_answer);
            gb_question.Controls.Add(txt_question);
            gb_question.Controls.Add(DECOR_lbl_answer);
            gb_question.Location = new Point(3, 3);
            gb_question.Name = "gb_question";
            gb_question.Size = new Size(114, 112);
            gb_question.TabIndex = 14;
            gb_question.TabStop = false;
            gb_question.Text = "---";
            // 
            // DECOR_lbl_question
            // 
            DECOR_lbl_question.AutoSize = true;
            DECOR_lbl_question.Location = new Point(6, 19);
            DECOR_lbl_question.Name = "DECOR_lbl_question";
            DECOR_lbl_question.Size = new Size(55, 15);
            DECOR_lbl_question.TabIndex = 10;
            DECOR_lbl_question.Text = "Pregunta";
            // 
            // txt_answer
            // 
            txt_answer.Location = new Point(6, 81);
            txt_answer.MaxLength = 128;
            txt_answer.Name = "txt_answer";
            txt_answer.Size = new Size(100, 23);
            txt_answer.TabIndex = 12;
            // 
            // txt_question
            // 
            txt_question.Location = new Point(6, 37);
            txt_question.MaxLength = 128;
            txt_question.Name = "txt_question";
            txt_question.Size = new Size(100, 23);
            txt_question.TabIndex = 1;
            // 
            // DECOR_lbl_answer
            // 
            DECOR_lbl_answer.AutoSize = true;
            DECOR_lbl_answer.Location = new Point(6, 63);
            DECOR_lbl_answer.Name = "DECOR_lbl_answer";
            DECOR_lbl_answer.Size = new Size(60, 15);
            DECOR_lbl_answer.TabIndex = 11;
            DECOR_lbl_answer.Text = "Respuesta";
            // 
            // SecurityQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gb_question);
            Name = "SecurityQuestion";
            Size = new Size(121, 119);
            gb_question.ResumeLayout(false);
            gb_question.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_question;
        private Label DECOR_lbl_question;
        private TextBox txt_answer;
        private TextBox txt_question;
        private Label DECOR_lbl_answer;
    }
}
