namespace TheDeptBook
{
    public class Contact
    {
        string? id;
        string? name;
        double? balance;

        public Contact()
        {
        }

        public Contact(string id, string name, double? balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        public string? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string? Name
        {
            get { return this.name; }
        }

        public double? Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
    }
}
