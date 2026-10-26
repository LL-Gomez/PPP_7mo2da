using System.Data;
using Common.Attributes;
using DataAccess.Tables;

namespace Domain.CRUD {
    public class User {
        static TABLE_sys_user user_table = new TABLE_sys_user();

        public DataTable Show() {
            return user_table.Show();
        }
        
        public DataTable getPage(int page) {
            return user_table.getPage(page);
        }

        public string? attemptLogin(string username, string password) {
            return user_table.attemptLogin(username, password);
        }

        public ATTR_User? getUserFromHash(string hash) {
            return user_table.useHashAsLogin(hash);
        }

        public ATTR_User? useHashAsLogin(string hash) {
            return user_table.useHashAsLogin(hash);
        }

        public void updateUser(int user_id, ATTR_User attributes, string hash) {
            // UNFINISHED
        }

        public void deleteUser(int user_id, string hash) {
            // UNFINISHED
        }

        public void addSecurityQuestionToSelf(string question, string answer, string hash) {
            user_table.addSecurityQuestionToSelf(question, answer, hash);
        }
    }
}