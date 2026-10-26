using Domain.CRUD;
using Domain.FileHandlers;

namespace Presentation {
    public partial class LoginForm : Form {
        HashFileManager hash_mng = new HashFileManager();
        User user_access = new User();

        public LoginForm() {
            if (hash_mng.tryLogInWithHash() != null) {
                this.Hide();

                openMainForm();

                return;
            }

            InitializeComponent();
        }

        private void attemptLogin(object sender, EventArgs e) {
            string? new_login_hash = user_access.attemptLogin(txt_username.Text, txt_password.Text);
            if (new_login_hash != null) {
                hash_mng.writeLoginHash(new_login_hash);

                openMainForm();
            }
        }

        void openMainForm() {
            MainForm new_form = new MainForm();

            new_form.FormClosed += onClose;
            new_form.Show();

            this.ShowInTaskbar = false;
            this.Opacity = 0;
        }

        void onClose(object? sender, FormClosedEventArgs e) {
            this.Close();
        }
    }
}
