using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Restaurante.Domain.Entities;
using Tp.Restaurante.Domain.IRepositories;

namespace Tp.Restaurante.AccessData.Repositories
{
    public class RepositoryFormaEntrega : IRepositoryFormaEntrega
    {
        public List<FormaEntrega> ListarFormaEntrega()
        {
            using (RestauranteContext _context = new RestauranteContext())
            {
                var listaFormaEntrega = _context.FormaEntregas.ToList();
                foreach (var item in listaFormaEntrega)
                {
                    Console.WriteLine(item.FormaEntregaId.ToString() + " )  " + item.Descripcion);
                }
                return listaFormaEntrega;
            }
        }
    }
}
