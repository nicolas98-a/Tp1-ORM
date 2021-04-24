using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Restaurante.ABM_CRUD;

namespace Tp.Restaurante
{
    public class Menu
    {   
        public void InitMenu()
        {
            try
            {
                MenuPrincipal();
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                while (opcion != 5)
                {

                    switch (opcion)
                    {
                        case 1:
                            Titulo();
                            Abm_Mercaderia.getInstance().RegistrarMercaderia();
                            // Console.WriteLine("ingreso la opcion 1 registara mercaderia");
                            InitMenu();
                            break;
                        case 2:
                            Titulo();
                            Abm_Comanda.getInstance().RegistrarComanda();
                            // Console.WriteLine("ingreso la opcion 2 para registrar comandas");
                            InitMenu();
                            break;
                        case 3:
                            Titulo();
                            Abm_Mercaderia.getInstance().ImprimirMercaderia();
                            // Console.WriteLine("ingreso la opcion 3 para lista mercaderia");
                            InitMenu();
                            break;
                        case 4:
                            Titulo();
                            Abm_Comanda.getInstance().ImprimirComanda();
                            // Console.WriteLine("ingreso la opcion 4 para listar comandas");
                            InitMenu();
                            break;
                        case 5:
                            Console.WriteLine("Salir del sistema");
                            break;
                        default:
                            Console.WriteLine("Mal ingresado");
                            break;

                    }
                    opcion = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception)
            {
                InitMenu();
            }
           

        }

        public static void Titulo ()
        {
            Console.WriteLine("******************************************************************************* \n"
                         +    "*****                               Restaurante                           ***** \n" + 
                              "*******************************************************************************");
        }
        public static void MenuPrincipal()
        {
            
            Titulo();
            Console.WriteLine("¿A que modulo desea ingresar? \n" + "\n");
            Console.WriteLine
                (
                    "1) Registrar mercaderia \n"+
                    "2) Hacer un pedido \n"+
                    "3) Listar toda la mercaderia \n" +
                    "4) Listar pedidos \n" + 
                    "5) Salir del sistema \n" + "\n"
                );
        }
    }
}
