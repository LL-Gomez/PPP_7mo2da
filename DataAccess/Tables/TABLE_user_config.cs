using System.Data;

using Common.Attributes;
using DataAccess.Connection;

namespace DataAccess.Tables {
    public class TABLE_user_config {
        public ATTR_SystemConfig getConfig() {
            SQLHelper sql_conn = new SQLHelper("getSystemConfig");
            sql_conn.Execute();

            DataTable result = sql_conn.Results;

            ATTR_SystemConfig config = new ATTR_SystemConfig(
                    int.Parse(result.Rows[0]["MinimumPasswordCharacters"].ToString()!),
                    int.Parse(result.Rows[0]["SecurityQuestionAmount"].ToString()!),
                    bool.Parse(result.Rows[0]["ForcePasswordCaps"].ToString()!),
                    bool.Parse(result.Rows[0]["ForcePasswordNumbers"].ToString()!),
                    bool.Parse(result.Rows[0]["ForcePasswordSpecials"].ToString()!),
                    bool.Parse(result.Rows[0]["TwoFactorRequired"].ToString()!),
                    bool.Parse(result.Rows[0]["AllowOldPasswords"].ToString()!),
                    bool.Parse(result.Rows[0]["VerifyIfHasCredentials"].ToString()!)
                )
            ;

            return config;
        }
    }
}
