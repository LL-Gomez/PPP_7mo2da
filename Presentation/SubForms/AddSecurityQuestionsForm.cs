using Common.Attributes;
using Domain.CRUD;
using Domain.FileHandlers;
using Presentation.CustomControls;

namespace Presentation.SubForms {
    public partial class AddSecurityQuestionsForm : Form {
        static HashFileManager hash_manager = new HashFileManager();
        string current_user_hash = hash_manager.getLoginHash();

        static SystemConfig config_communication = new SystemConfig();
        ATTR_SystemConfig config = config_communication.getSystemConfig();

        User user_access = new User();

        List<SecurityQuestion> questions = new List<SecurityQuestion>();

        public AddSecurityQuestionsForm() {
            ATTR_User? actual_user = hash_manager.tryLogInWithHash();
            if (actual_user == null) {
                MessageBox.Show("Not a valid account!!!");
                this.Close();
                return;
            }

            InitializeComponent();

            int question_count = config.SecurityQuestionAmount;
            for (int i = 1; i < question_count + 1; i++) {
                SecurityQuestion new_sq = new SecurityQuestion(i);

                questions.Add(new_sq);
                flowLayoutPanel1.Controls.Add(new_sq);
            }
        }

        (bool, string) check_for_validity() {
            foreach (SecurityQuestion s_question in questions) {
                if (s_question.getQuestion().Length <= 0) {
                    return (false, $"Question {s_question.getNumber()} cannot be empty!");
                }

                if (s_question.getAnswer().Length <= 0) {
                    return (false, $"Answer {s_question.getNumber()} cannot be empty!");
                }
            }
            return (true, "");
        }

        void onSendButtonPress(object _, EventArgs __) {
            (bool success, string error) = check_for_validity();
            if (!success) {
                MessageBox.Show(error);
                return;
            }

            foreach (SecurityQuestion s_question in questions) {
                user_access.addSecurityQuestionToSelf(
                    s_question.getQuestion(), s_question.getAnswer(),
                    current_user_hash
                );
            }

            this.Close();
        }
    }
}
