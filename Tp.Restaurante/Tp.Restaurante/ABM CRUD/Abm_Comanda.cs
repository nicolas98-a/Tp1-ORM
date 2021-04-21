using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Restaurante.AccessData.Repositories;
using Tp.Restaurante.Domain.Entities;

namespace Tp.Restaurante.ABM_CRUD
{
    public class Abm_Comanda
    {
        GenericsRepository _repository;
        RepositoryFormaEntrega _repositoryFormaEntrega;
        RepositoryComandaMercaderia _repositoryComandaMercaderia;

        static Abm_Comanda unicoabmComanda = null;

        private Abm_Comanda()
        {
            _repository = new GenericsRepository();
            _repositoryFormaEntrega = new RepositoryFormaEntrega();
            _repositoryComandaMercaderia = new RepositoryComandaMercaderia();
        }
        public static Abm_Comanda getInstance()
        {
            if ( unicoabmComanda == null)
            {
                unicoabmComanda = new Abm_Comanda();
            }
            return unicoabmComanda;
        }

        public void RegistrarComanda()
        {
           // Guid idComanda = new Guid();
            List<Mercaderia> listaMercaderias = _repositoryComandaMercaderia.SeleccionarMercaderia();
            int total = CalcularPrecioTotal(listaMercaderias);
            int idFormaEntrega = SeleccionarFormaEntrega();
            if ( idFormaEntrega == 0)
            {
                Console.WriteLine("Mal ingresado, no corresponde a ninguna forma de entrega");
            }
            else
            {
                var entity = new Comanda
                {
                    ComandaId = new Guid(),
                    FormaEntregaId = idFormaEntrega,
                    PrecioTotal = total,
                    Fecha = new DateTime()
                };
                _repository.Add(entity);
                

                /*
                foreach (var item in listaMercaderias)
                {
                    Abm_ComandaMercaderia.getInstance().RegistrarComandaMercaderia(item.MercaderiaId, idComanda);
                } */
            }


        }

        public int SeleccionarFormaEntrega()
        {
            Console.WriteLine("Seleccione la forma de entrega de su comanda: ");
            List<FormaEntrega> lista = _repositoryFormaEntrega.ListarFormaEntrega();
            int opc = int.Parse(Console.ReadLine());
            if (opc <= lista.Count)
            {
                return opc;
            }
            else
            {
                return 0;
            }
        }

        public int CalcularPrecioTotal(List<Mercaderia> mercaderias)
        {
            int total = 0;
            List<Mercaderia> aux = mercaderias ;
            foreach (var item in aux)
            {
                total += item.Precio;
            }

            return total;
        }


    }
}
