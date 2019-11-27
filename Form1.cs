using proyectoLibrary;
using proyectoLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private Filter filter = new Filter();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // open default file

            FileManager fileManager = new FileManager();

            FileRead fileRead = new FileRead();
            fileRead.Path = @"C:\Users\Core\Documents\UDEO\2019 T4\Progra IB\Proyecto\default.txt";

            listaVehiculos = fileRead.ReadFile();

            initDataGridViewSource();

            // Adding options to comboVehicleType filter

            comboVehicleType.Items.Add(Vehicle.Vehicletype.Sedan);
            comboVehicleType.Items.Add(Vehicle.Vehicletype.Coupe);
            comboVehicleType.Items.Add(Vehicle.Vehicletype.HatchBack);
            comboVehicleType.Items.Add(Vehicle.Vehicletype.SUV);
            comboVehicleType.Items.Add(Vehicle.Vehicletype.PickUp);
            comboVehicleType.Items.Add(Vehicle.Vehicletype.Camioneta);

            //radio1.Text = Parking.ParkingQuadrant.NorthEast.ToString();
            //radio2.Text = Parking.ParkingQuadrant.NorthWest.ToString();
            //radio3.Text = Parking.ParkingQuadrant.SouthEast.ToString();
            //radio4.Text = Parking.ParkingQuadrant.SouthWest.ToString();
        }

        private void txtFilterOwner_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = filter.ByOwner(txtFilterOwner.Text);
            dataGridView1.Refresh();
        }

        private void comboVehicleType_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = filter.ByVehicleType((Vehicle.Vehicletype)comboVehicleType.SelectedItem);
            dataGridView1.Refresh();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtFilterOwner.Text = string.Empty;
            comboVehicleType.Text = "Type";
            initDataGridViewSource();
        }

        private void initDataGridViewSource()
        {
            BindingSource bindingSource = new BindingSource
            {
                DataSource = listaVehiculos
            };

            dataGridView1.DataSource = bindingSource;
            dataGridView1.Refresh();
        }
    }
}
