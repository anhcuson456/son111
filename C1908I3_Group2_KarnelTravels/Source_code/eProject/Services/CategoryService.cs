using eProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Services
{
    public interface CategoryService
    {
        public List<CategoryServi> findAll();
        public CategoryServi find(int id);
        public CategoryServi Edit(CategoryServi categoryServi);
        public List<CategoryServi> SearchSerByName(string keyword);

        public void Delete(int id);
        CategoryServi Create(CategoryServi categoryServi);

        public List<CategoryTour> findAllTour();
        public CategoryTour findTour(int id);
        public List<CategoryTour> SearchByNameTour(string keyword);

        public CategoryTour EditTour(CategoryTour categoryTour);
        public void DeleteTour(int id);
        CategoryTour CreateTour(CategoryTour categoryTour);
    }
}
