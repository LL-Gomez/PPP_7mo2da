using Domain.CRUD;
using Common.Attributes;

namespace Domain.FileHandlers {
    public class HashFileManager {
        static string dir = @"C:\PPP_7mo2da";
        static string file_path = Path.Combine(dir, "login_hash.txt");
        User user_access = new User();

        public void createHashFile() {
            Directory.CreateDirectory(dir);
            File.Create(file_path);
        }

        public bool hashFileExists() {
            if (!File.Exists(file_path)) {
                return false;
            }

            return true;
        }

        public string getLoginHash() {
            string result = File.ReadAllText(file_path);

            return result;
        }

        public void writeLoginHash(string hash) {
            File.WriteAllText(file_path, hash);
        }

        public ATTR_User? tryLogInWithHash() {
            if (!hashFileExists()) {
                createHashFile();
            }

            ATTR_User? user_info;
            string login_hash = getLoginHash();

            if (login_hash != "") {
                user_info = user_access.useHashAsLogin(login_hash);
            } else {
                return null;
            }

            return user_info;
        }
    }
}
