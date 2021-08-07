using eProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Services
{
    public class ServiServieImpl : ServiService
    {
        private DatabaseContext db;
        public ServiServieImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public Comment Add(Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
            return comment;
        }

        public bool Check(string id)
        {
            return db.Servis.Count(a => a.Id.Contains(id)) > 0;
        }

        public Servi Create(Servi servi)
        {
            db.Servis.Add(servi);
            db.SaveChanges();
            return servi;
        }

        public Img CreateImg(Img img)
        {
            db.Imgs.Add(img);
            db.SaveChanges();
            return img;
        }

        public void Delete(string id)
        {
            db.Servis.Remove(db.Servis.Find(id));
            db.SaveChanges();
        }

        public void DeleteImg(int id)
        {
            db.Imgs.Remove(db.Imgs.Find(id));
            db.SaveChanges();
        }

        public void Edit(Servi servi)
        {
            db.Entry(servi).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public Img EditImg(Img img)
        {
            db.Entry(img).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return img;
        }

        public Servi find(string id)
        {
            return db.Servis.SingleOrDefault(d => d.Id == id);
        }

        public List<Servi> findAll()
        {
            return db.Servis.ToList();
        }

        public int findID(string username)
        {
            return db.Accounts.Where(p => p.Username == username).Select(x => x.Id).FirstOrDefault();
        }

        public Img findImg(int id)
        {
            return db.Imgs.SingleOrDefault(d => d.Id == id);
        }

        public List<Servi> SearchAll(string keyword)
        {
            return db.Servis.Where(a => a.Name.Contains(keyword) || a.Addr.Contains(keyword) || a.Descrip.Contains(keyword)).ToList();
        }

        public List<Servi> SearchByName(string keyword)
        {
            return db.Servis.Where(a => a.Name.Contains(keyword)).ToList();
        }

        public List<Servi> SearchByPrice(decimal min, decimal max)
        {
            return db.Servis.Where(a => a.Price >= min && a.Price <= max).ToList();
        }

        public List<Servi> SearchSerByCate(int cate)
        {
            return db.Servis.Where(a => a.Category.Id == cate).ToList();
        }
    }
}
