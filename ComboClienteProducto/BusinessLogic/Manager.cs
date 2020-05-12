using DataAccess;
using Domain;
using System;
using System.Collections.Generic;
using System.Windows;

namespace BusinessLogic
{
    public class Manager
    {
        public static List<Client> acquireClient()
        {
            try
            {
                return Functions.ObtainClient();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error al abrir la Base de Datos de CLIENTES.\n" + e.Message);
                List<Client> vacio = new List<Client>();
                return vacio;
            }
            
        }

        public static List<Product> acquireProduct()
        {
            try
            {
                return Functions.ObtainProduct();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error al abrir la Base de Datos de PRODUCTOS.\n" + e.Message);
                List<Product> vacio = new List<Product>();
                return vacio;
            }   
        }
        public static List<Combos> acquireCombo()
        {
            try
            {
                return Functions.ObtainCombos();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error al abrir la Base de Datos de COMBOS.\n" + e.Message);
                List<Combos> vacio = new List<Combos>();
                return vacio;
            }
        }

        public static void saveCombo(Combos combo)
        {
            if (combo.Cantidad == 0)
            {
                MessageBox.Show("Tiene que ingresar una cantidad para hacer un combo.");
            }
            else if(combo.IdProducto==0)
            {
                MessageBox.Show("Tiene que elegir un producto.");
            }else if (combo.IdCliente == 0)
            {
                MessageBox.Show("Tiene que elegir un cliente.");
            } else{
                Functions.GuardarCombo(combo);
            }
        }

        public static List<ComboCP> acquireCP(int id)
        {
            try
            {
                return Functions.ObtainComboCP(id);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error al abrir Grid View.\n" + e.Message);
                List<ComboCP> vacio = new List<ComboCP>();
                return vacio;
            }
        }
    }
}
