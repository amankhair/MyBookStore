using MyBookStore.DAL;
using System.Collections.Generic;
using System.Linq;

namespace MyBookStore.BAL
{
    public class Methods
    {
        public static BookStoreDB db = new BookStoreDB();
        public string book = "";
        CategoryTable ct = new CategoryTable();

        #region GetTables
        public List<BookTable> GetBookTable()
        {
            return db.BookTable.ToList();
        }


        //---------- Category Methods ----------------//
        public List<CategoryTable> GetCategoryTable()
        {
            return db.CategoryTable.ToList();
        }

        public List<BookTable> SearchBookName(string str)
        {
            return db.BookTable.Where(item => item.b_nm == str).ToList();
        }

        public void BookName(string str)
        {
            book = str;
        }

        public string bbb()
        {
            return book;
        }


        //--------------Contact Meyhods ------------//

        public List<ContactTable> GetContactTable()
        {
            return db.ContactTable.ToList();
        }

        public List<SubcatTable> GetSubcatTable()
        {
            return db.SubcatTable.ToList();
        }

        public List<UserTable> GetUserTable()
        {
            return db.UserTable.ToList();
        }
        #endregion

        //-------------------------------------------------------//

        public void AddNewBook(BookTable book)
        {
            db.BookTable.Add(book);
            db.SaveChanges();
        }

        public void DeleteBook(BookTable book)
        {
            db.BookTable.Remove(book);
            db.SaveChanges();
        }

        public void AddNewCategory(CategoryTable ct)
        {
            db.CategoryTable.Add(ct);
            db.SaveChanges();
        }

        public List<CategoryTable> Name { get; set; }

        public List<CategoryTable> GetCategoryName()
        {
            return Name = db.CategoryTable.ToList();
        }

        public void AddNewUser(UserTable us)
        {
            db.UserTable.Add(us);
            db.SaveChanges();
        }
    }
}
