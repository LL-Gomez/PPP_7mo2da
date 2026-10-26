using System.Diagnostics.CodeAnalysis;
using Common.Attributes;

namespace Common.Attributes
{
    public class ATTR_User
    {
        public Role         Role;
        public string       Username;
        public string       Name;
        public string       Email;
        public DateTime?    CreationDate;

        [SetsRequiredMembers]
        public ATTR_User(string _username, string _name, string _email, Role? _role, DateTime? _creationdate)
        {
            this.Username = _username;
            this.Name = _name;
            this.Email = _email;
            this.CreationDate = _creationdate;

            if (_role == null) {
                this.Role = new Role(-1, "Unassigned");
            } else {
                this.Role = _role;
            }
        }
    }
}
