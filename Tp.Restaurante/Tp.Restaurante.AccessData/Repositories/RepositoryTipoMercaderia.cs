using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Restaurante.Domain.Entities;
using Tp.Restaurante.Domain.IRepositories;

namespace Tp.Restaurante.AccessData.Repositories
{
    public class RepositoryTipoMercaderia : IRepositoryTipoMercaderia
    {
       /* private readonly RestauranteContext _context;
        public RepositoryTipoMercaderia (RestauranteContext dbContext)
        {
            _context = dbContext;
        }
       */
        public List<TipoMercaderia> ListarTipo ()
        {   
            using (RestauranteContext _context = new RestauranteContext())
            {
                var listaTipo = _context.TipoMercaderias.ToList();
                foreach (var item in listaTipo)
                {
                    Console.WriteLine(item.TipoMercaderiaId.ToString() + ")  " + item.Descripcion);
                }
                return listaTipo;
            }

        }
    }
}
