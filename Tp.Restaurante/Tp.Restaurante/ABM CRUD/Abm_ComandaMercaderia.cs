using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Restaurante.AccessData.Repositories;
using Tp.Restaurante.Domain.Entities;

namespace Tp.Restaurante.ABM_CRUD
{
    public class Abm_ComandaMercaderia
    {
        GenericsRepository _repository;

        static Abm_ComandaMercaderia unicoabm_ComandaMercaderia = null;
        private Abm_ComandaMercaderia()
        {
            _repository = new GenericsRepository();
        }
        public static Abm_ComandaMercaderia getInstance()
        {
            if (unicoabm_ComandaMercaderia == null)
            {
                unicoabm_ComandaMercaderia = new Abm_ComandaMercaderia();
            }
            return unicoabm_ComandaMercaderia;
        }

        public void RegistrarComandaMercaderia( int idMercaderia , Guid idComanda)
        {
            var entity = new ComandaMercaderia 
            {
                
                MercaderiaId = idMercaderia, 
                ComandaId = idComanda

            };
            _repository.Add(entity);
        }




    }
}
