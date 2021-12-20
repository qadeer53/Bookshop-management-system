using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement
{
    public class DBAccess
    {
        public int Insert(Signup sgp)
        {
            myDBEntities1 db = new myDBEntities1();
            db.Signups.Add(sgp);
            return db.SaveChanges();
        }
        public Signup Authenticate(string username, string password)
        {
            myDBEntities1 db = new myDBEntities1();
            return db.Signups.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();

        }
        public int Insert(AddBook abk)
        {
            myDBEntities1 db = new myDBEntities1();
            db.AddBooks.Add(abk);
            return db.SaveChanges();
        }
        public List<AddBook> SelectAll()
        {
            return new myDBEntities1().AddBooks.ToList();
        }
    }
}
