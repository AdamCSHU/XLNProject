namespace XLN_Home.Shared
{
    public class User
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User()
        {

        }
        public User(int conID, string fName, string lName)
        {
            this.ContactID = conID;
            this.FirstName = fName;
            this.LastName = lName;
        }
    }
}
