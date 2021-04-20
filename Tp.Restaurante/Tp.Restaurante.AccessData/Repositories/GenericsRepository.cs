using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Restaurante.Domain.IRepositories;

namespace Tp.Restaurante.AccessData.Repositories
{
    public class GenericsRepository : IGenericsRepository
    {   /*
        private readonly RestauranteContext _context;
        public GenericsRepository ( RestauranteContext dbContext)
        {
            _context = dbContext;
        }
          */ 
        public void Add<T>(T entity) where T : class
        {    
            using (RestauranteContext _context = new RestauranteContext())
            {
                _context.Add(entity);
                _context.SaveChanges();
            }

        }
    }
}
