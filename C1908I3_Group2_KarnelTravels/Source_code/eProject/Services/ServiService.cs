using eProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Services
{
    public interface ServiService
    {
        bool Check(string id);
        public List<Servi> findAll();

        Servi Create(Servi servi);

        public void Edit(Servi servi);

        public Servi find(string id);

        public void Delete(string id);

        public int findID(string username);
        Comment Add(Comment comment);

        List<Servi> SearchByPrice(decimal min, decimal max);
        public List<Servi> SearchSerByCate(int cate);

        public List<Servi> SearchByName(string keyword);

        public List<Servi> SearchAll(string keyword);

        public Img findImg(int id);
        public Img CreateImg(Img img);
        public Img EditImg(Img img);
        public void DeleteImg(int id);

    }
}
