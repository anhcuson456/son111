using eProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Services
{
    public class TravelServiceImpl : TravelService
    {
        private DatabaseContext db;
        public TravelServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }
        public Travel Create(Travel travel)
        {
            db.Travels.Add(travel);
            db.SaveChanges();
            return travel;
        }

        public ServiTravel CreateSerTra(ServiTravel serviTravel)
        {
            db.ServiTravels.Add(serviTravel);
            db.SaveChanges();
            return serviTravel;
        }

        public TourTravel CreateTouTra(TourTravel tourTravel)
        {
            db.TourTravels.Add(tourTravel);
            db.SaveChanges();
            return tourTravel;
        }

        public void Delete(int id)
        {
            db.Travels.Remove(db.Travels.Find(id));
            db.SaveChanges();
        }

        public void DeleteSerTra(int id)
        {
            db.ServiTravels.Remove(db.ServiTravels.Find(id));
            db.SaveChanges();
        }

        public void DeleteTouTra(int id)
        {
            db.TourTravels.Remove(db.TourTravels.Find(id));
            db.SaveChanges();
        }

        public Travel Edit(Travel travel)
        {

            db.Entry(travel).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return travel;
        }

        public Travel find(int id)
        {
            return db.Travels.SingleOrDefault(d => d.Id == id);
        }

        public List<Travel> findAll()
        {
            return db.Travels.ToList();
        }

        public List<Travel> SearchByName(string keyword)
        {
            return db.Travels.Where(a => a.Name.Contains(keyword)).ToList();

        }
    }
}
