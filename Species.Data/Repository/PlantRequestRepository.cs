using System;
using System.Collections.Generic;
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
        }
    }
}
