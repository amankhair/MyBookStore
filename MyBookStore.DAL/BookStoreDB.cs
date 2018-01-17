namespace MyBookStore.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BookStoreDB : DbContext
    {
        public BookStoreDB()
            : base("name=BookStoreDB")
        {
        }

        public virtual DbSet<BookTable> BookTable { get; set; }
        public virtual DbSet<CategoryTable> CategoryTable { get; set; }
        public virtual DbSet<ContactTable> ContactTable { get; set; }
        public virtual DbSet<SubcatTable> SubcatTable { get; set; }
        public virtual DbSet<UserTable> UserTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookTable>()
                .Property(e => e.b_nm)
                .IsUnicode(false);

            modelBuilder.Entity<BookTable>()
                .Property(e => e.b_subcat)
                .IsUnicode(false);

            modelBuilder.Entity<BookTable>()
                .Property(e => e.b_desc)
                .IsUnicode(false);

            modelBuilder.Entity<BookTable>()
                .Property(e => e.b_publisher)
                .IsUnicode(false);

            modelBuilder.Entity<BookTable>()
                .Property(e => e.b_edition)
                .IsUnicode(false);

            modelBuilder.Entity<BookTable>()
                .Property(e => e.b_isbn)
                .IsUnicode(false);

            modelBuilder.Entity<BookTable>()
                .Property(e => e.b_img)
                .IsUnicode(false);

            modelBuilder.Entity<BookTable>()
                .Property(e => e.b_pdf)
                .IsUnicode(false);

            modelBuilder.Entity<BookTable>()
                .Property(e => e.b_author)
                .IsUnicode(false);

            modelBuilder.Entity<CategoryTable>()
                .Property(e => e.cat_nm)
                .IsUnicode(false);

            modelBuilder.Entity<ContactTable>()
                .Property(e => e.con_nm)
                .IsUnicode(false);

            modelBuilder.Entity<ContactTable>()
                .Property(e => e.con_email)
                .IsUnicode(false);

            modelBuilder.Entity<ContactTable>()
                .Property(e => e.con_query)
                .IsUnicode(false);

            modelBuilder.Entity<SubcatTable>()
                .Property(e => e.subcat_nm)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.u_fnm)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.u_lname)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.u_unm)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.u_pwd)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.u_gender)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.u_email)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.u_contact)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.u_city)
                .IsUnicode(false);
        }
    }
}
