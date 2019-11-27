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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileManager fileManager = new FileManager();

            FileRead fileRead = new FileRead();
            fileRead.Path = @"C:\Users\Core\Documents\UDEO\2019 T4\Progra IB\Proyecto\default.txt";

            listaVehiculos = fileRead.ReadFile();

            BindingSource bindingSource = new BindingSource
            {
                DataSource = listaVehiculos
            };

            dataGridView1.DataSource = bindingSource;
            dataGridView1.Refresh();


            //radio1.Text = Parking.ParkingQuadrant.NorthEast.ToString();
            //radio2.Text = Parking.ParkingQuadrant.NorthWest.ToString();
            //radio3.Text = Parking.ParkingQuadrant.SouthEast.ToString();
            //radio4.Text = Parking.ParkingQuadrant.SouthWest.ToString();
        }

        private void panelCreateParking_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
