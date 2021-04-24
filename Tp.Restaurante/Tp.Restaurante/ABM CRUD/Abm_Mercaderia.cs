using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Restaurante.AccessData;
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
            try
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

                if (nombre != "" & precio.ToString() != "" & ingredientes != "" & preparacion != "" & imagen != "")
                {
                    int idTipo = SeleccionarTipoMercaderia();
                    if (idTipo == 0)
                    {
                        Console.WriteLine("Mal ingresado, no corresponde a ningun tipo");
                    }
                    else
                    {
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

                        Console.WriteLine("Mercaderia registrada con exito"); 
                    }
                }
                else
                {
                    Console.WriteLine("Error mal ingresado, no puede haber campos vacios");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error mal ingresado");
            }

        }

        public int SeleccionarTipoMercaderia()
        {
            Console.WriteLine("Seleccione el tipo de mercaderia: ");
            List<TipoMercaderia> lista = _repositoryTipoMercaderia.ListarTipo();
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

        public void ImprimirMercaderia()
        {
            using (RestauranteContext _context = new RestauranteContext())
            {
                var lista = _context.Mercaderias.ToList();
                foreach (var item in lista)
                {
                    string tipo = _context.TipoMercaderias.Find(item.TipoMercaderiaId).Descripcion;
                    Console.WriteLine
                        (
                           "            Tipo de mercaderia: " + tipo + "\n" +
                           "Mercaderia : " + item.Nombre + "\n" +
                           "Precio: " + item.Precio.ToString() + "\n" +
                           "Ingredientes: " + item.Ingredientes + "\n" +
                           "Preparacion: " + item.Preparacion + "\n" +
                           "Imagen: " + item.Imagen + "\n"
                        );
                }
            }
        }
    }
}
