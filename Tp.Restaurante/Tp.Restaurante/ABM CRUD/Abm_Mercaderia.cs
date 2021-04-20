using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Restaurante.AccessData.Repositories;
using Tp.Restaurante.Domain.Entities;

namespace Tp.Restaurante.ABM_CRUD
{
    public class Abm_Mercaderia
    {
        //  private readonly IGenericsRepository _repository;
        //  private readonly IRepositoryTipoMercaderia _repositoryTipoMercaderia;

        GenericsRepository _repository;
        RepositoryTipoMercaderia _repositoryTipoMercaderia;
        static Abm_Mercaderia unicoabmMercaderia = null;

        /*
        public ABM_Mercaderia ( IGenericsRepository repository , IRepositoryTipoMercaderia repositoryTipoMercaderia)
        {
            _repository = repository;
            _repositoryTipoMercaderia = repositoryTipoMercaderia;
        }
        */
        private Abm_Mercaderia()
        {
            _repository = new GenericsRepository();
            _repositoryTipoMercaderia = new RepositoryTipoMercaderia();
        }

        public static Abm_Mercaderia getInstance()
        {
            if (unicoabmMercaderia == null)
            {
                unicoabmMercaderia = new Abm_Mercaderia();
            }
            return unicoabmMercaderia;
        }
        public void RegistrarMercaderia()
        {
            Console.WriteLine("Ingrese el nombre de la mercaderia: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el precio de la mercaderia: ");
            int precio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los ingredientes: ");
            string ingredientes = Console.ReadLine();

            Console.WriteLine("Ingrese la preparacion: ");
            string preparacion = Console.ReadLine();

            Console.WriteLine("Ingrese la imagen de la preparacion: ");
            string imagen = Console.ReadLine();

            // lista del tipo de mercaderia y elegir el id
            int idTipo = SeleccionarTipoMercaderia();

            var entity = new Mercaderia
            {
                Nombre = nombre,
                Precio = precio,
                Ingredientes = ingredientes,
                Preparacion = preparacion,
                Imagen = imagen,
                TipoMercaderiaId = idTipo

            };
            _repository.Add(entity);
        }

        public int SeleccionarTipoMercaderia()
        {
            Console.WriteLine("Seleccione el tipo de mercaderia: ");
            List<TipoMercaderia> lista = _repositoryTipoMercaderia.ListarTipo();
            int opc = int.Parse(Console.ReadLine());

            return opc;

        }
    }
}
