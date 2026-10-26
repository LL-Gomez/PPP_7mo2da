using Common.Attributes;
using Domain.FileHandlers;
using Domain.CRUD;

namespace Presentation {
    public partial class DeleteUserForm : Form {
        HashFileManager hash_manager = new HashFileManager();
        User user_access = new User();
        int selected_user_id;

        public DeleteUserForm(int _selected_user_id) {
            ATTR_User? actual_user = hash_manager.tryLogInWithHash();
            if (actual_user == null) {
                MessageBox.Show("Not a valid account!!!");
                this.Close();
                return;
            }

            if (actual_user.Role.Name != "Admin") {
                MessageBox.Show("Not an admin!!!");
                this.Close();
                return;
            }

            selected_user_id = _selected_user_id;

            InitializeComponent();

            txt_user_id.Text = selected_user_id.ToString();
        }
         
        (bool, string) check_for_validity() {
            if (!(int.TryParse(txt_user_id.Text.ToString(), out int value))) return (false, "Id del usuario no es un numero!");

            return (true, "");
        }

        private void onDeleteButtonClick(object sender, EventArgs e) {
            (bool success, string error) = check_for_validity();
            if (!success) {
                MessageBox.Show(error);
                return;
            }

            // TODO: Make this Fucking Work             :3
            user_access.deleteUser(selected_user_id, hash_manager.getLoginHash());
        }
    }
}
