using proyectoLibrary;
using proyectoLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParqueoAdministrator
{
    public sealed class Filter
    {
        public List<Vehicle> ByVehicleType(Vehicle.Vehicletype type)
        {
            List<Vehicle> list = new List<Vehicle>();

            foreach (var item in Form1.listaVehiculos)
            {
                if (item.Type == type)
                {
                    list.Add(item);
                }
            }

            return list;
        }

        public List<Vehicle> ByOwner(string name)
        {
            name = name.ToLower();

            List<Vehicle> list = new List<Vehicle>();

            foreach (var item in Form1.listaVehiculos)
            {
                string[] ownerArray = item.Owner.ToLower().Split();

                //MessageBox.Show(ownerArray[0] + ownerArray[1]);

                for (int i = 0; i < ownerArray.Length; i++)
                {
                    //MessageBox.Show(name);
                    //MessageBox.Show(ownerArray[i]);


                    if (name == ownerArray[i])
                    {
                        list.Add(item);
                    }
                }
            }

            if (list.Count > 0)
            {
                return list;
            }

            return Form1.listaVehiculos;
        }
    }
}
