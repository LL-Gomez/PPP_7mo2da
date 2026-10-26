namespace Presentation.SubForms {
    partial class AddSecurityQuestionsForm {
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
            btn_send = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btn_send
            // 
            btn_send.Location = new Point(54, 187);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(75, 23);
            btn_send.TabIndex = 9;
            btn_send.Text = "Enviar";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += this.onSendButtonPress;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(155, 169);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // FirstLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(179, 219);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btn_send);
            Name = "FirstLoginForm";
            Text = "First Login";
            ResumeLayout(false);
        }

        #endregion
        private Button btn_send;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}