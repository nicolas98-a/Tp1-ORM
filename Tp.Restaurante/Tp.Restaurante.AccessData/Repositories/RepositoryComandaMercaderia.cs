using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Restaurante.Domain.Entities;

namespace Tp.Restaurante.AccessData.Repositories
{
    public class RepositoryComandaMercaderia
    { 
        RepositoryMercaderia _repositoryMercaderia = new RepositoryMercaderia();
        public List<Mercaderia> SeleccionarMercaderia()
        {
            List<Mercaderia> mercaderiaSeleccionada = new List<Mercaderia>();
            Console.WriteLine("Seleccione la mercaderia que desea agregar a su pedido: ");
            Console.WriteLine("Ingrese 0 para terminar ");
            List<Mercaderia> lista = _repositoryMercaderia.ListarMercaderia();
            
            int opc = int.Parse(Console.ReadLine());
            while (opc != 0)
            {
                if (opc <= lista.Count)
                {   
                    mercaderiaSeleccionada.Add(lista[opc - 1]);
                }
                else
                {
                    Console.WriteLine("Mal ingresado, no corresponde a una mercaderia");
                }
                opc = int.Parse(Console.ReadLine());
            }
           
            return mercaderiaSeleccionada;
        }
    }
}
