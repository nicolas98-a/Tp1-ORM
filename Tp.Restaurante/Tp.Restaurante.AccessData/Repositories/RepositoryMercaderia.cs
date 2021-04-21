using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Restaurante.Domain.Entities;
using Tp.Restaurante.Domain.IRepositories;

namespace Tp.Restaurante.AccessData.Repositories
{
    public class RepositoryMercaderia : IRepositoryMercaderia
    {
        public List<Mercaderia> ListarMercaderia()
        {
            using (RestauranteContext _context = new RestauranteContext())
            {
                var listaMercaderia = _context.Mercaderias.ToList();
                foreach (var item in listaMercaderia)
                {
                    Console.WriteLine(item.MercaderiaId.ToString() + " ) " + item.Nombre + "  precio: " + item.Precio.ToString());
                }
                return listaMercaderia;
            }
        }


    }
}
