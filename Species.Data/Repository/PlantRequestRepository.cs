using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Species.Data.Data;
using Species.Data.Models;
using Species.Data.Repository.IRepository;

namespace Species.Data.Repository
{
    public class PlantRequestRepository : Repository<PlantRequest>, IPlantRequestRepository
    {
        private readonly ApplicationDbContext _db;

        public PlantRequestRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(PlantRequest plantRequest)
        {
            var objFromDb = _db.PlantRequests.FirstOrDefault(s => s.Id == plantRequest.Id);
            if (objFromDb != null)
            {
                //objFromDb.Name = plantRequest.Name;
                objFromDb.CountyId = plantRequest.CountyId;
                objFromDb.County = plantRequest.County;
                objFromDb.SubCounty = plantRequest.SubCounty;
                objFromDb.Location = plantRequest.Location;
                objFromDb.Specie = plantRequest.Specie;
            }
        }
    }
}
