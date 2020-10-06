using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Species.Data.Data;
using Species.Data.Models;
using Species.Data.Repository.IRepository;

namespace Species.Data.Repository
{
    public class SpecieRepository : Repository<Specie>, ISpecieRepository
    {
        private readonly ApplicationDbContext _db;

        public SpecieRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Specie specie)
        {
            var objFromDb = _db.Species.FirstOrDefault(s => s.Id == specie.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = specie.Name;
            }
        }
    }
}
