using DataAccess.Tables;

using System.Data;
using Common.Attributes;

namespace Domain.CRUD {
    public class SystemConfig {
        static TABLE_user_config config_sql_access = new TABLE_user_config();

        public ATTR_SystemConfig getSystemConfig() {
            return config_sql_access.getConfig();
        }
    }
}
