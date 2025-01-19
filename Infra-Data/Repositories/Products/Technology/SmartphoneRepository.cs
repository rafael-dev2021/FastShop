using Domain.Entities.Products.Technology.T_Smartphones;
using Domain.Interfaces.Products.Technology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_Data.Repositories.Products.Technology
{
    internal class SmartphoneRepository : ISmartphoneRepository
    {
        public Task<Smartphone> CreateAsync(Smartphone entity)
        {
            throw new NotImplementedException();
        }

        public Task<Smartphone> DeleteAsync(Smartphone entity)
        {
            throw new NotImplementedException();
        }

        public Task<Smartphone> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Smartphone>> GetEntitiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Smartphone> UpdateAsync(Smartphone entity)
        {
            throw new NotImplementedException();
        }
    }
}
