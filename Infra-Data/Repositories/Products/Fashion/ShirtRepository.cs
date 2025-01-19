using Domain.Entities.Products.Fashion.F_TShirt;
using Domain.Interfaces.Products.Fashion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_Data.Repositories.Products.Fashion
{
    internal class ShirtRepository : IShirtRepository
    {
        public Task<Shirt> CreateAsync(Shirt entity)
        {
            throw new NotImplementedException();
        }

        public Task<Shirt> DeleteAsync(Shirt entity)
        {
            throw new NotImplementedException();
        }

        public Task<Shirt> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Shirt>> GetEntitiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Shirt> UpdateAsync(Shirt entity)
        {
            throw new NotImplementedException();
        }
    }
}
