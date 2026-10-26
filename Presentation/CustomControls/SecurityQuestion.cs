using System.ComponentModel;

namespace Presentation.CustomControls {
    public partial class SecurityQuestion : UserControl {
        public int Number = 0;

        public SecurityQuestion(int question_number) {
            InitializeComponent();

            this.Number = question_number;
            gb_question.Text = question_number.ToString();
        }

        public int getNumber() {
            return this.Number;
        }

        public string getQuestion() {
            return txt_question.Text;
        }

        public string getAnswer() {
            return txt_answer.Text;
        }
    }
}
