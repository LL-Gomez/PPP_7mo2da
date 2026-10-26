using Common.Attributes;
using Domain.CRUD;
using Domain.FileHandlers;

namespace Presentation {
    public partial class ControlPanel : Form {
        HashFileManager hash_manager = new HashFileManager();
        User user_access        = new User();

        int page_count          = 1;
        int? selected_user_id   = null;

        public ControlPanel() {
            ATTR_User? actual_user = hash_manager.tryLogInWithHash();
            if (actual_user == null) {
                MessageBox.Show("Not a valid account!!!");
                this.Close();
                return;
            }

            if (actual_user.Role.ID != 1) {
                MessageBox.Show("Not an admin!!!");
                this.Close();
                return;
            }

            InitializeComponent();

            updatePage(page_count);
        }

        void updatePage(int page) {
            txt_page.Text = page_count.ToString();
            dgv_main.DataSource = user_access.getPage(page_count);
        }

        private void decreasePageCount(object sender, EventArgs e) {
            if (page_count == 1) return;

            page_count -= 1;
            updatePage(page_count);
        }

        private void increasePageCount(object sender, EventArgs e) {
            page_count += 1;
            updatePage(page_count);
        }

        private void onCreateButtonPress(object sender, EventArgs e) {
            if (selected_user_id == null) return;

            CreateUserForm new_form = new CreateUserForm();
            if (new_form == null || new_form.IsDisposed) return;

            new_form.Show();
        }

        private void onUpdateButtonPress(object sender, EventArgs e) {
            if (selected_user_id == null) return;

            int not_nullable = selected_user_id.Value;
            UpdateUserForm new_form = new UpdateUserForm(not_nullable);
            if (new_form == null || new_form.IsDisposed) return;

            new_form.Show();
        }

        private void onDeleteButtonPress(object sender, EventArgs e) {
            if (selected_user_id == null) return;

            int not_nullable = selected_user_id.Value;
            DeleteUserForm new_form = new DeleteUserForm(not_nullable);
            if (new_form == null || new_form.IsDisposed) return;

            new_form.Show();
        }

        private void onRowSelectUpdate(object sender, DataGridViewCellEventArgs e) {
            if (dgv_main.SelectedRows.Count == 0) {
                selected_user_id = null;
                return;
            }

            DataGridViewRow row = dgv_main.SelectedRows[0];
            selected_user_id = int.Parse(row.Cells["UserId"].Value!.ToString()!);
        }
    }
}