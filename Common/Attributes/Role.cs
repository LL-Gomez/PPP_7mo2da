namespace Common.Attributes {
    public class Role {
        public int ID { get; }
        public string Name { get; }

        public Role(int _id, string _name) {
            this.ID = _id;
            this.Name = _name;
        }
    }
}
