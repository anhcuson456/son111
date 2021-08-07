using eProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Services
{
    public class AccountServiceImpl : AccountService
    {
        private DatabaseContext db;
        public AccountServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public Account Register(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }

        public Account Login(string username, string password)
        {
            var account = db.Accounts.SingleOrDefault(p => p.Username == username);
            if (account != null)
            {
                 if (BCrypt.Net.BCrypt.Verify(password, account.Pass))
                    return account;
                else
                    return null;
            }
            return null;
        }

        public void Edit(Account account)
        {
            db.Entry(account).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public Account find(int id)
        {
            return db.Accounts.SingleOrDefault(d => d.Id == id);
        }

        public Feedback Create(Feedback feedback)
        {
            db.Feedbacks.Add(feedback);
            db.SaveChanges();
            return feedback;
        }

        public List<Account> findAll()
        {
            return db.Accounts.ToList();
        }

        public Account CreateAcc(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }

        public List<Feedback> findAllFee()
        {
            return db.Feedbacks.ToList();
        }

        public Feedback findFee(int id)
        {
            return db.Feedbacks.SingleOrDefault(d => d.Id == id);
        }

        public Feedback EditFee(Feedback feedback)
        {
            db.Entry(feedback).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return feedback;
        }

        public void DeleteFee(int id)
        {
            db.Feedbacks.Remove(db.Feedbacks.Find(id));
            db.SaveChanges();
        }

        public List<Comment> findAllCom()
        {
            return db.Comments.ToList();
        }

        public void DeleteCom(int id)
        {
            db.Comments.Remove(db.Comments.Find(id));
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Accounts.Remove(db.Accounts.Find(id));
            db.SaveChanges();
        }

        public Account findUser(string username)
        {
            return db.Accounts.SingleOrDefault(d => d.Username == username);
        }

        public void Profile(Account account)
        {
            db.Entry(account).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public List<Account> SearchByName(string keyword)
        {
            return db.Accounts.Where(a => a.Name.Contains(keyword)).ToList();

        }

        public bool Check(string username)
        {
            return db.Accounts.Count(a => a.Username.Contains(username)) > 0;
        }

        public int CountAcc()
        {
            var acc = db.Accounts.ToList();
            return acc.Count();
        }

        public int CountTou()
        {
            var tou = db.TouristSpots.ToList();
            return tou.Count();
        }

        public int CountSer()
        {
            var ser = db.Servis.ToList();
            return ser.Count();
        }

        public int CountTra()
        {
            var tra = db.Travels.ToList();
            return tra.Count();
        }

    }
}
