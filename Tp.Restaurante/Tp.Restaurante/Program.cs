using System;
using Tp.Restaurante.ABM_CRUD;
using Tp.Restaurante.AccessData;

using Tp.Restaurante.Domain.Entities;

namespace Tp.Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hola mundo");

            Abm_Mercaderia.getInstance().RegistrarMercaderia();



        }
    }
}
