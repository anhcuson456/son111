using eProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Services
{
    public class CategoryServiceImpl : CategoryService
    {
        private DatabaseContext db;
        public CategoryServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public CategoryServi Create(CategoryServi categoryServi)
        {
            db.CategoryServis.Add(categoryServi);
            db.SaveChanges();
            return categoryServi;
        }

        public CategoryTour CreateTour(CategoryTour categoryTour)
        {
            db.CategoryTours.Add(categoryTour);
            db.SaveChanges();
            return categoryTour;
        }

        public void Delete(int id)
        {
            db.CategoryServis.Remove(db.CategoryServis.Find(id));
            db.SaveChanges();
        }

        public void DeleteTour(int id)
        {
            db.CategoryTours.Remove(db.CategoryTours.Find(id));
            db.SaveChanges();
        }

        public CategoryServi Edit(CategoryServi categoryServi)
        {
            db.Entry(categoryServi).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return categoryServi;
        }

        public CategoryTour EditTour(CategoryTour categoryTour)
        {
            db.Entry(categoryTour).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return categoryTour;
        }

        public CategoryServi find(int id)
        {
            return db.CategoryServis.SingleOrDefault(d => d.Id == id);
        }

        public List<CategoryServi> findAll()
        {
            return db.CategoryServis.ToList();
        }

        public List<CategoryTour> findAllTour()
        {
            return db.CategoryTours.ToList();

        }

        public CategoryTour findTour(int id)
        {
            return db.CategoryTours.SingleOrDefault(d => d.Id == id);

        }

        public List<CategoryServi> SearchSerByName(string keyword)
        {
            return db.CategoryServis.Where(a => a.Name.Contains(keyword)).ToList();

        }

        public List<CategoryTour> SearchByNameTour(string keyword)
        {
            return db.CategoryTours.Where(a => a.Name.Contains(keyword)).ToList();
            
        }
    }
}
