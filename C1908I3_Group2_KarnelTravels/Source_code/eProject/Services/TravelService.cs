using eProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject.Services
{
   public interface TravelService
    {

        public List<Travel> findAll();

        public Travel Create(Travel travel);
        public List<Travel> SearchByName(string keyword);

        public Travel Edit(Travel travel);

        public Travel find(int id);

        public void Delete(int id);

        public ServiTravel CreateSerTra(ServiTravel serviTravel);
        public void DeleteSerTra(int id);

        public TourTravel CreateTouTra(TourTravel tourTravel);
        public void DeleteTouTra(int id);

    }
}
