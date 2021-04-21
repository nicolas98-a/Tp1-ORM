using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Restaurante.Domain.Entities;

namespace Tp.Restaurante.Domain.IRepositories
{
    public interface IRepositoryMercaderia
    {
        List<Mercaderia> ListarMercaderia();
    }
}
