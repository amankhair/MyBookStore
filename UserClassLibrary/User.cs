using MyBookStore.DAL;

namespace UserClassLibrary
{
    public class User : UserTable
    {
        private static BookStoreDB db = new BookStoreDB();

        private User(string fname, string lname, string uname, string pass, string gender, string email, string contact,
            string ucity)
        {
            u_fnm = fname;
            u_lname = lname;
            u_unm = uname;
            u_pwd = pass;
            u_gender = gender;
            u_email = email;
            u_contact = contact;
            u_city = ucity;
        }

        //------------ Registration Method --------------//

        public static void Registration(string fname, string lname, string gender, string email, string contact, string login, string pass, string city)
        {
            UserTable ut = new UserTable();
            ut.u_fnm = fname;
            ut.u_lname = lname;
            ut.u_gender = gender;
            ut.u_unm = login;
            ut.u_pwd = pass;
            ut.u_email = email;
            ut.u_contact = contact;
            ut.u_city = city;

            db.UserTable.Add(ut);
            db.SaveChanges();

        }
    }
}
