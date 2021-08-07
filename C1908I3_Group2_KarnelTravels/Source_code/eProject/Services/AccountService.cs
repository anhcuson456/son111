using eProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Services
{
    public interface AccountService
    {
        bool Check(string username);
        public List<Account> findAll();

        Account Login(string username, string password);

        public List<Account> SearchByName(string keyword);

        Account Register(Account account);

        public Account find(int id);

        public void Delete(int id);

        public void Edit(Account account);

        public Account findUser(string username);

        public void Profile(Account account);

        Feedback Create(Feedback feedback);

        Account CreateAcc(Account account);

        public List<Feedback> findAllFee();
        public Feedback findFee(int id);
        public Feedback EditFee(Feedback feedback);
        public void DeleteFee(int id);

        public List<Comment> findAllCom();
        public void DeleteCom(int id);

        int CountAcc();
        int CountTou();
        int CountSer();
        int CountTra();
    }
}
