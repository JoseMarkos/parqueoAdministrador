using proyectoLibrary;
using proyectoLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParqueoAdministrator
{
    public partial class Form1 : Form
    {
        public static List<CuentaParqueo> listaCuentaParqueo = new List<CuentaParqueo>();
        public static List<Vehicle> listaVehiculos = new List<Vehicle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle(Vehicle.Vehicletype.Coupe, "Pss", "Marcos", "Holis");
            Vehicle vehicle2 = new Vehicle(Vehicle.Vehicletype.Coupe, "Pswwwws", "Jose Culajay", "ww");
            Vehicle vehicle3 = new Vehicle(Vehicle.Vehicletype.Camioneta, "Pss", "Jose Marcos", "aa");

            listaVehiculos.Add(vehicle);
            listaVehiculos.Add(vehicle2);
            listaVehiculos.Add(vehicle3);

            CuentaParqueo cuentaParqueo = new CuentaParqueo();
            CuentaParqueo cuentaParqueo1 = new CuentaParqueo();
            CuentaParqueo cuentaParqueo2 = new CuentaParqueo();

            cuentaParqueo.GuardarInformacionPersonal("Marcos", 24);
            cuentaParqueo2.GuardarInformacionPersonal("Jorge", 26);
            cuentaParqueo1.GuardarInformacionPersonal("Denisse", 23);

            cuentaParqueo.GuardarListaDeCarros(listaVehiculos);

            listaCuentaParqueo.Add(cuentaParqueo);
            listaCuentaParqueo.Add(cuentaParqueo1);
            listaCuentaParqueo.Add(cuentaParqueo2);

            BindingSource bindingSource = new BindingSource
            {
                DataSource = listaCuentaParqueo
            };

            dataGridView1.DataSource = bindingSource;
            dataGridView1.Refresh();

            Filter filter = new Filter();


            dataGridView1.DataSource = filter.ByVehicleType(Vehicle.Vehicletype.Camioneta);
            dataGridView1.Refresh();
        }
    }
}
