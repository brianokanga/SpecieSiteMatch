using System;
using System.Collections.Generic;
using System.Text;
using Species.Data.Models;

namespace Species.Data.Repository.IRepository
{

    public interface IPlantRequestRepository : IRepository<PlantRequest>
    {
        void Update(PlantRequest plantRequest);
    }
}
