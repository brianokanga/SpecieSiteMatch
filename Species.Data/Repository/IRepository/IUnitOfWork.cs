using System;
using System.Collections.Generic;
using System.Text;

namespace Species.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IPlantRequestRepository PlantRequest { get; }
        ISpecieRepository Specie { get; }
        
        ISP_Call SP_Call { get; }

        void Save();
    }
}
