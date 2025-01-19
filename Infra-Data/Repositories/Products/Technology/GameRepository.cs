using Domain.Entities.Products.Technology.T_Games;
using Domain.Interfaces.Products.Technology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_Data.Repositories.Products.Technology
{
    internal class GameRepository : IGameRepository
    {
        public Task<Game> CreateAsync(Game entity)
        {
            throw new NotImplementedException();
        }

        public Task<Game> DeleteAsync(Game entity)
        {
            throw new NotImplementedException();
        }

        public Task<Game> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Game>> GetEntitiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Game> UpdateAsync(Game entity)
        {
            throw new NotImplementedException();
        }
    }
}
