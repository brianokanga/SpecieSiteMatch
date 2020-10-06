using System;
using System.Collections.Generic;
using System.Text;
using Species.Data.Models;

namespace Species.Data.Repository.IRepository
{
    public interface ISpecieRepository : IRepository<Specie>
    {
        void Update(Specie specie);
    }
}
