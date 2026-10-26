using Common.Attributes;
using Domain.CRUD;
using Domain.FileHandlers;

namespace Presentation {
    public partial class CreateUserForm : Form {
        HashFileManager hash_manager = new HashFileManager();
        User user_access = new User();

        public CreateUserForm() {
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

            InitializeComponent();
        }
    }
}
