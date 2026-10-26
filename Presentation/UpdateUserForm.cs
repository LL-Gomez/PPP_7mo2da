using Common.Attributes;
using Domain.CRUD;
using Domain.FileHandlers;

namespace Presentation {
    public partial class UpdateUserForm : Form {
        HashFileManager hash_manager = new HashFileManager();

        User user_access = new User();
        int selected_user_id;

        public UpdateUserForm(int _selected_user_id) {
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

            lbl_user_id.Text = selected_user_id.ToString();
        }

        (bool, string) check_for_validity() {
            if (txt_role_id.Text.Length == 0) return (false, "Id del rol no puede estar vacio!");
            if (!(int.TryParse(txt_role_id.Text.ToString(), out int _))) return (false, "Id del rol no es un numero!");

            if (txt_username.Text.Length > 16) return (false, $"Nombre de usuario muy largo! ({txt_username.Text.Length})");
            if (txt_username.Text.Length == 0) return (false, "Nombre de usuario no puede estar vacio!");

            if (txt_name.Text.Length == 0) return (false, "Nombre no puede estar vacio!");

            if (txt_email.Text.Length == 0) return (false, "E-mail no puede estar vacio!");
            if (!(txt_email.Text.Count(a => a == '@') == 1
                && txt_email.Text.Count(b => b == '.') == 1)) return (false, "Ingrese un correo valido!");

            if (txt_cuit.Text.Length == 0) return (false, "CUIT no puede estar vacio!");
            if (!(int.TryParse(txt_cuit.Text.ToString(), out int _))) return (false, "CUIT no es un numero!");

            return (true, "");
        }

        private void onUpdateButtonClick(object sender, EventArgs e) {
            (bool success, string error) = check_for_validity();
            if (!success) {
                MessageBox.Show(error);
                return;
            }

            int id_role = int.Parse(txt_role_id.Text);

            string username = txt_username.Text;
            string name = txt_name.Text;
            string email = txt_email.Text;

            ATTR_User user_attributes = new ATTR_User(username, name, email, new Role(id_role, ""), null);

            // TODO: Make this Fucking Work             :3
            user_access.updateUser(selected_user_id, user_attributes, hash_manager.getLoginHash());
        }
    }
}