using eProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Services
{
    public class TouristServiceImpl : TouristService
    {
        private DatabaseContext db;
        public TouristServiceImpl(DatabaseContext _db)
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
            return db.TouristSpots.Count(a => a.Id.Contains(id)) > 0;
        }

        public TouristSpot Create(TouristSpot touristSpot)
        {
            db.TouristSpots.Add(touristSpot);
            db.SaveChanges();
            return touristSpot;
        }

        public Img CreateImg(Img img)
        {
            db.Imgs.Add(img);
            db.SaveChanges();
            return img;
        }

        public void Delete(string id)
        {
            db.TouristSpots.Remove(db.TouristSpots.Find(id));
            db.SaveChanges();
        }

        public void DeleteImg(int id)
        {
            db.Imgs.Remove(db.Imgs.Find(id));
            db.SaveChanges();
        }

        public void Edit(TouristSpot touristSpot)
        {
            db.Entry(touristSpot).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public Img EditImg(Img img)
        {
            db.Entry(img).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return img;
        }

        public TouristSpot Find(string id)
        {
            return db.TouristSpots.Find(id);
        }

        public List<TouristSpot> findAll()
        {
            return db.TouristSpots.ToList();
        }

        public List<CategoryServi> findCate()
        {
            return db.CategoryServis.ToList();
        }

        public int findID(string username)
        {
            return db.Accounts.Where(p => p.Username == username).Select(x => x.Id).FirstOrDefault();
        }

        public Img findImg(int id)
        {
            return db.Imgs.SingleOrDefault(d => d.Id == id);
        }

        public List<TouristSpot> SearchAll(string keyword)
        {
            return db.TouristSpots.Where(a => a.Name.Contains(keyword) || a.Descrip.Contains(keyword) || a.Active.Contains(keyword) || a.Addr.Contains(keyword)).ToList();
        }

        public List<TouristSpot> SearchByName(string keyword)
        {
            return db.TouristSpots.Where(a => a.Name.Contains(keyword)).ToList();

        }
        public List<TouristSpot> SearchTourByCate(int cate)
        {
            return db.TouristSpots.Where(a => a.Category.Id == cate).ToList();
        }
    }
}
