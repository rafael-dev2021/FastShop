using Domain.Entities.Products.Fashion.F_Shoes;
using Domain.Interfaces.Products.Fashion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_Data.Repositories.Products.Fashion
{
    internal class ShoesRepository : IShoesRepository
    {
        public Task<Shoes> CreateAsync(Shoes entity)
        {
            throw new NotImplementedException();
        }

        public Task<Shoes> DeleteAsync(Shoes entity)
        {
            throw new NotImplementedException();
        }

        public Task<Shoes> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Shoes>> GetEntitiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Shoes> UpdateAsync(Shoes entity)
        {
            throw new NotImplementedException();
        }
    }
}
