using proyectoLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParqueoAdministrator
{
    public partial class Administrator : Form
    {
        public static List<Parking> ListaParqueos = new List<Parking>();
        public static List<Vehicle> listaVehiculos = new List<Vehicle>();
        private Filter filter = new Filter();
        private FileRead fileRead = new FileRead();
        private int rowId;

        public Administrator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // open default Vehicle file

            fileRead.PathVehicle = @"C:\Users\Core\Documents\UDEO\2019 T4\Progra IB\Proyecto\default.txt";

            listaVehiculos = fileRead.ReadVehicleFile();

            initDataGridViewSource();

            // Adding options to comboVehicleType filter

            comboVehicleType.Items.Add(Vehicle.Vehicletype.Sedan);
            comboVehicleType.Items.Add(Vehicle.Vehicletype.Coupe);
            comboVehicleType.Items.Add(Vehicle.Vehicletype.HatchBack);
            comboVehicleType.Items.Add(Vehicle.Vehicletype.SUV);
            comboVehicleType.Items.Add(Vehicle.Vehicletype.PickUp);
            comboVehicleType.Items.Add(Vehicle.Vehicletype.Camioneta);

            // Adding options to comboTypeLicensePlate filter

            comboTypeLicensePlate.Items.Add(Filter.licensePlatePrefix.A);
            comboTypeLicensePlate.Items.Add(Filter.licensePlatePrefix.C);
            comboTypeLicensePlate.Items.Add(Filter.licensePlatePrefix.CC);
            comboTypeLicensePlate.Items.Add(Filter.licensePlatePrefix.CD);
            comboTypeLicensePlate.Items.Add(Filter.licensePlatePrefix.DIS);
            comboTypeLicensePlate.Items.Add(Filter.licensePlatePrefix.E);
            comboTypeLicensePlate.Items.Add(Filter.licensePlatePrefix.EXT);
            comboTypeLicensePlate.Items.Add(Filter.licensePlatePrefix.M);
            comboTypeLicensePlate.Items.Add(Filter.licensePlatePrefix.MI);
            comboTypeLicensePlate.Items.Add(Filter.licensePlatePrefix.O);
            comboTypeLicensePlate.Items.Add(Filter.licensePlatePrefix.P);
            comboTypeLicensePlate.Items.Add(Filter.licensePlatePrefix.TC);
            comboTypeLicensePlate.Items.Add(Filter.licensePlatePrefix.TRC);
            comboTypeLicensePlate.Items.Add(Filter.licensePlatePrefix.U);
        }

        private void initDataGridViewSource()
        {
            BindingSource bindingSource = new BindingSource
            {
                DataSource = listaVehiculos
            };

            dgvVehiculos.DataSource = bindingSource;
            dgvVehiculos.Refresh();
            dgvVehiculos.CurrentCell = null;
        }

        private void initDataGridViewSource(List<Parking> list)
        {
            BindingSource bindingSource = new BindingSource
            {
                DataSource = list
            };

            dgvParqueos.DataSource = bindingSource;
            dgvParqueos.Refresh();
            dgvParqueos.CurrentCell = null;
        }

        private void SelectVehiclePanel()
        {
            splitParking.Hide();
            splitMain.Show();
        }

        private void SelectParkingPanel()
        {
            fileRead.PathParking = @"C:\Users\Core\Documents\UDEO\2019 T4\Progra IB\Proyecto\parkingList.txt";

            ListaParqueos = fileRead.ReadParkingFile();
            initDataGridViewSource(ListaParqueos);

            splitMain.Hide();
            splitParking.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectParkingPanel();
        }

        private void btnParqueos2_Click(object sender, EventArgs e)
        {
            SelectParkingPanel();
        }

        private void btnVehiculos2_Click(object sender, EventArgs e)
        {
            SelectVehiclePanel();
        }

        private void Vehiculos_Click(object sender, EventArgs e)
        {
            SelectVehiclePanel();
        }

        private void btnGetOut_Click(object sender, EventArgs e)
        {
            dgvVehiculos.Rows.RemoveAt(rowId);

            FileManager fileMaganer = new FileManager();
            fileMaganer.CreateParkingFile("hoy.txt");
            fileMaganer.WriteParkingFile("hoy.txt", listaVehiculos);

            if (comboVehicleType.SelectedItem != null)
            {
                filter.ByVehicleType((Vehicle.Vehicletype)comboVehicleType.SelectedItem, dgvVehiculos);
            }

            if (comboTypeLicensePlate.SelectedItem != null)
            {
                filter.ByLisencePlate((Filter.licensePlatePrefix)comboTypeLicensePlate.SelectedItem, dgvVehiculos);
            }
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowId = e.RowIndex;
        }

        #region Filter
        private void txtFilterOwner_TextChanged(object sender, EventArgs e)
        {
            filter.ByOwner(txtFilterOwner.Text, dgvVehiculos);
        }

        private void comboVehicleType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboVehicleType.SelectedItem != null)
            {
                filter.ByVehicleType((Vehicle.Vehicletype)comboVehicleType.SelectedItem, dgvVehiculos);
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtFilterOwner.Text = "";

            comboVehicleType.SelectedItem = null;
            comboVehicleType.Text = "Type";

            comboTypeLicensePlate.SelectedItem = null;
            comboTypeLicensePlate.Text = "License Plate Type";

            initDataGridViewSource();
        }

        private void comboTypeLicensePlate_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboTypeLicensePlate.SelectedItem != null)
            {
                filter.ByLisencePlate((Filter.licensePlatePrefix)comboTypeLicensePlate.SelectedItem, dgvVehiculos);
            }
        }
        #endregion
    }
}
