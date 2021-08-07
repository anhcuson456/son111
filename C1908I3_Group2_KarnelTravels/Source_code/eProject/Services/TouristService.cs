using eProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Services
{
    public interface TouristService
    {
        bool Check(string id);
        public List<TouristSpot> findAll();

        public List<CategoryServi> findCate();

        public TouristSpot Find(string id);

        TouristSpot Create(TouristSpot touristSpot);

        public void Edit(TouristSpot touristSpot);

        public void Delete(string id);
        public List<TouristSpot> SearchTourByCate(int cate);

        public List<TouristSpot> SearchByName(string keyword);

        public int findID(string username);
        Comment Add(Comment comment);

        public Img findImg(int id);
        public Img CreateImg(Img img);
        public Img EditImg(Img img);
        public void DeleteImg(int id);

        public List<TouristSpot> SearchAll(string keyword);

    }
}
