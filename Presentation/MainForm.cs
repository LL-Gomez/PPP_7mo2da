using Common.Attributes;
using Domain.FileHandlers;
using Presentation.SubForms;

namespace Presentation
{
    public partial class MainForm : Form {
        HashFileManager hash_mng = new HashFileManager();
        ATTR_User? current_user_info;

        public MainForm() {
            ATTR_User? new_user_info = hash_mng.tryLogInWithHash();
            if (new_user_info == null) { this.Close(); return; }

            InitializeComponent();

            current_user_info = new_user_info;

            lbl_username.Text = current_user_info.Username;
            lbl_email.Text = current_user_info.Email;
            lbl_name.Text = current_user_info.Name;
            lbl_creationdate.Text = current_user_info.CreationDate.ToString();
        }

        private void btn_control_panel_Click(object sender, EventArgs e) {
            ControlPanel _n = new ControlPanel();
            if (_n == null || _n.IsDisposed) return;
            _n.Show();
        }

        private void btn_change_questions_Click(object sender, EventArgs e) {
            AddSecurityQuestionsForm t = new AddSecurityQuestionsForm();
            t.Show();
        }
    }
}
