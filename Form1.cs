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
            CuentaParqueo cuentaParqueo = new CuentaParqueo();
            CuentaParqueo cuentaParqueo2 = new CuentaParqueo();
            CuentaParqueo cuentaParqueo3 = new CuentaParqueo();

            Vehicle vehicle = new Vehicle
                ("Marcos"
                , cuentaParqueo.ID
                , Vehicle.Vehicletype.Coupe
                , "Pss"
                , "Holis");

            listaVehiculos.Add(vehicle);

            cuentaParqueo.GuardarInformacionPersonal("Marcos");
            cuentaParqueo2.GuardarInformacionPersonal("Jorge");
            cuentaParqueo3.GuardarInformacionPersonal("Denisse");

            cuentaParqueo.GuardarListaDeCarros(listaVehiculos);

            listaCuentaParqueo.Add(cuentaParqueo);
            listaCuentaParqueo.Add(cuentaParqueo3);
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


            radio1.Text = Parking.ParkingQuadrant.NorthEast.ToString();
            radio2.Text = Parking.ParkingQuadrant.NorthWest.ToString();
            radio3.Text = Parking.ParkingQuadrant.SouthEast.ToString();
            radio4.Text = Parking.ParkingQuadrant.SouthWest.ToString();

        }

        private void panelCreateParking_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
