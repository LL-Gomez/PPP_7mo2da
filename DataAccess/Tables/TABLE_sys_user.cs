using System.Data;

using Common.Attributes;
using DataAccess.Connection;

namespace DataAccess.Tables
{
    public class TABLE_sys_user
    {
        public DataTable Show()
        {
            SQLHelper sql_conn = new SQLHelper("getAllUsers");
            sql_conn.Execute();

            return sql_conn.Results;
        }

        public DataTable getPage(int page) {
            SQLHelper sql_conn = new SQLHelper("getUserPage");
            sql_conn.AddParameter("@INPUT_page", page);

            sql_conn.Execute();

            return sql_conn.Results;
        }

        public ATTR_User? useHashAsLogin(string hash) {
            SQLHelper sql_conn = new SQLHelper("getUserFromHash");
            sql_conn.AddParameter("@INPUT_hash", hash);

            sql_conn.Execute();

            ATTR_User user_data;

            DataTable result = sql_conn.Results;

            if (result.Rows.Count == 0 || result.Rows[0] == null) {
                return null;
            }

            Role user_role = new Role(
                    int.Parse(result.Rows[0]["RoleId"].ToString()!),
                    result.Rows[0]["RoleName"].ToString()!
                );

            user_data = new ATTR_User(
                    result.Rows[0]["Username"].ToString()!,
                    result.Rows[0]["Name"].ToString()!,
                    result.Rows[0]["Email"].ToString()!,
                    user_role,
                    DateTime.Parse(result.Rows[0]["CreationDate"].ToString()!)
                    );
            return user_data;
        }

        public string? attemptLogin(string username, string password)
        {
            SQLHelper sql_conn = new SQLHelper("attemptLogin");
            sql_conn.AddParameter("@INPUT_username_email",  username);
            sql_conn.AddParameter("@INPUT_password",        password);

            sql_conn.Execute();

            DataTable result = sql_conn.Results;
            bool found_result = result.Rows.Count > 0;
            string? hash = null;
            if (found_result)
            {
                hash = result.Rows[0]["Result"].ToString();
            }

            return hash;
        }
        public void addSecurityQuestionToSelf(string question, string answer, string hash) {
            SQLHelper sql_conn = new SQLHelper("addSecurityQuestionToSelf");
            sql_conn.AddParameter("@INPUT_question", question);
            sql_conn.AddParameter("@INPUT_answer", answer);
            sql_conn.AddParameter("@INPUT_hash", hash);

            sql_conn.Execute();
        }
    }
}
