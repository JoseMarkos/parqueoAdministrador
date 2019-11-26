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
    class Filter
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
    }
}
