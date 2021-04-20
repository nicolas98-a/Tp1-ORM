using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp.Restaurante.Domain.IRepositories
{
    public interface IGenericsRepository
    {
        void Add<T>(T entity) where T : class;
    }
}
